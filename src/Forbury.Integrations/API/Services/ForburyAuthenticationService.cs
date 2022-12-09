using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Forbury.Integrations.API.Exceptions;
using Forbury.Integrations.API.Interfaces;
using Forbury.Integrations.API.Models;
using Forbury.Integrations.API.Models.Configuration;
using Forbury.Integrations.Helpers.Extensions;
using IdentityServer4.Models;
using Microsoft.Extensions.Options;

namespace Forbury.Integrations.API.Services
{
    public class ForburyAuthenticationService : IForburyAuthenticationService
    {
        private static Dictionary<string, TokenResponse> _tokens = new Dictionary<string, TokenResponse>();
        private static readonly SemaphoreSlim _tokenSemaphore = new SemaphoreSlim(1, 1);

        private readonly HttpClient _httpClient;
        private readonly ForburyConfiguration _configuration;

        public ForburyAuthenticationService(HttpClient httpClient,
            IOptions<ForburyConfiguration> configurationOptions)
        {
            _httpClient = httpClient;
            _configuration = configurationOptions.Value;
        }

        public async Task<string> GetAccessTokenAsync(CancellationToken cancellationToken, string clientName = null)
        {
            ValidateClientConfiguration(clientName);

            var customerClient = string.IsNullOrEmpty(clientName) ?
                _configuration.Authentication.Clients.FirstOrDefault().Value :
                _configuration.Authentication.Clients.FirstOrDefault(c => string.Equals(c.Key, clientName, StringComparison.InvariantCultureIgnoreCase)).Value;

            if (IsAuthorised(customerClient.ClientId))
                return _tokens[customerClient.ClientId].AccessToken;

            await _tokenSemaphore.WaitAsync(cancellationToken);            

            try
            {
                var data = new FormUrlEncodedContent(new Dictionary<string, string>
                {
                    {"grant_type", GrantType.ClientCredentials},
                    {"client_id", customerClient.ClientId},
                    {"client_secret", customerClient.ClientSecret}
                });

                HttpResponseMessage response = await _httpClient.PostAsync("connect/token", data, cancellationToken);
                response.EnsureSuccessStatusCode();
                _tokens[customerClient.ClientId] = await response.Content.ReadAsObjectAsync<TokenResponse>();
            }
            catch (Exception ex)
            {
                throw new ForburyAuthenticationException("Error authenticating with Forbury servers.", ex);
            }
            finally
            {
                _tokenSemaphore.Release();
            }

            return _tokens[customerClient.ClientId].AccessToken;
        }

        private bool IsAuthorised(string clientId)
        {
            // Added 30 second buffer for request times
            return _tokens.ContainsKey(clientId) && DateTime.UtcNow.AddSeconds(30) < _tokens[clientId].ExpiresOn;
        }

        private void ValidateClientConfiguration(string clientName)
        {
            if (_configuration.Authentication.Clients == null || !_configuration.Authentication.Clients.Any())
            {
                throw new ForburyAuthenticationException("No Forbury API clients have been configured.");
            }

            if (string.IsNullOrEmpty(clientName) && _configuration.Authentication.Clients.Count > 1)
            {
                throw new ForburyAuthenticationException("Must specify client name when more than one client is configured.");
            }

            if (!string.IsNullOrEmpty(clientName) && !_configuration.Authentication.Clients.Any(c => string.Equals(c.Key, clientName, StringComparison.InvariantCultureIgnoreCase)))
            {
                throw new ForburyAuthenticationException($"Client with name '{clientName}' is not configured.");
            }
        }
    }
}
