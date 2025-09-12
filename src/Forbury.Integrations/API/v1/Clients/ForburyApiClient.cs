using Forbury.Integrations.API.Exceptions;
using Forbury.Integrations.API.Models;
using Forbury.Integrations.API.Models.Configuration;
using Forbury.Integrations.API.v1.Interfaces;
using Forbury.Integrations.Helpers.Extensions;
using Microsoft.AspNetCore.Http.Extensions;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Forbury.Integrations.API.v1.Clients
{
    public abstract class ForburyApiClient : IForburyApiClient
    {
        const string ApplicationJson = "application/json";

        protected readonly HttpClient _httpClient;

        private readonly ForburyConfiguration _configuration;

        public ForburyApiClient(HttpClient httpClient, ForburyConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }

        public void SetClient(string name)
        {
            if (_httpClient.DefaultRequestHeaders.Contains(Constants.ClientHeaderName))
            {
                _httpClient.DefaultRequestHeaders.Remove(Constants.ClientHeaderName);
            }

            _httpClient.DefaultRequestHeaders.Add(Constants.ClientHeaderName, name);
        }

        public void SetClient(string name, AuthenticationClientConfiguration clientConfiguration)
        {
            // Try remove and then add new client
            _configuration.Authentication.Clients.Remove(name);
            _configuration.Authentication.Clients.Add(name, clientConfiguration);

            SetClient(name);
        }

        protected QueryBuilder GetPagedQueryBuilder(int amount, int page)
        {
            return new QueryBuilder
            {
                { "amount", amount.ToString() },
                { "page", page.ToString() }
            };
        }

        protected async Task<TResult> GetAsync<TResult>(string requestUri, CancellationToken cancellationToken)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(requestUri, cancellationToken);

            await CatchResponseFailure(response);

            try
            {
                return await response.Content.ReadAsObjectAsync<TResult>();
            }
            catch (Exception ex)
            {
                throw new ForburyApiException("Invalid response type.", ex);
            }
        }

        protected async Task<TResult> PostAsync<TRequest, TResult>(string requestUri, TRequest requestBody, CancellationToken cancellationToken)
        {
            var serializedBody = JsonConvert.SerializeObject(requestBody, new JsonSerializerSettings() { ContractResolver = new CamelCasePropertyNamesContractResolver() });

            HttpResponseMessage response = await _httpClient.PostAsync(requestUri,
                new StringContent(serializedBody, Encoding.UTF8, ApplicationJson),
                cancellationToken);

            await CatchResponseFailure(response);

            try
            {
                return await response.Content.ReadAsObjectAsync<TResult>();
            }
            catch (Exception ex)
            {
                throw new ForburyApiException("Invalid response type.", ex);
            }
        }

        protected async Task<(Stream FileStream, string ContentType, string FileName)> GetFileAsync(string requestUri, CancellationToken cancellationToken)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(requestUri, cancellationToken);

            await CatchResponseFailure(response);

            try
            {
                return (await response.Content.ReadAsStreamAsync(), response.Content.Headers.ContentType.MediaType, response.Content.Headers.ContentDisposition.FileNameStar);
            }
            catch (Exception ex)
            {
                throw new ForburyApiException("Invalid response type.", ex);
            }
        }

        protected async Task CatchResponseFailure(HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode) return;

            var message = "An unknown error occurred while processing your request.";
            try
            {
                var forburyApiError = await response.Content.ReadAsObjectAsync<ForburyApiError>();
                message = forburyApiError.Message;
            }
            catch { }

            throw new ForburyApiException(message, response.StatusCode);
        }
    }
}
