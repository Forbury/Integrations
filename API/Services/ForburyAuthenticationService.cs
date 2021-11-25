using System;
using System.Collections.Generic;
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
        private static TokenResponse _token;
        private static readonly SemaphoreSlim _tokenSemaphore = new SemaphoreSlim(1, 1);

        private readonly HttpClient _httpClient;
        private readonly ForburyConfiguration _configuration;

        public ForburyAuthenticationService(HttpClient httpClient,
            IOptions<ForburyConfiguration> configurationOptions)
        {
            _httpClient = httpClient;
            _configuration = configurationOptions.Value;
        }

        public async Task<string> GetAccessTokenAsync(CancellationToken cancellationToken)
        {
            await _tokenSemaphore.WaitAsync(cancellationToken);            

            try
            {
                if (IsAuthorised())
                    return _token.AccessToken;

                var data = new FormUrlEncodedContent(new Dictionary<string, string>
                {
                    {"grant_type", GrantType.ClientCredentials},
                    {"client_id", _configuration.Authentication.ClientId},
                    {"client_secret", _configuration.Authentication.ClientSecret}
                });

                HttpResponseMessage response = await _httpClient.PostAsync("connect/token", data, cancellationToken);
                response.EnsureSuccessStatusCode();
                _token = await response.Content.ReadAsObjectAsync<TokenResponse>();
            }
            catch (Exception ex)
            {
                throw new ForburyAuthenticationException("Error authenticating with Forbury servers.", ex);
            }
            finally
            {
                _tokenSemaphore.Release();
            }

            return _token.AccessToken;
        }

        private bool IsAuthorised()
        {
            // Added 30 second buffer for request times
            return _token != null && DateTime.UtcNow.AddSeconds(30) < _token.ExpiresOn;
        }
    }
}
