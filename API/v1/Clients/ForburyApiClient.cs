using Forbury.Integrations.API.Exceptions;
using Forbury.Integrations.API.Models;
using Forbury.Integrations.API.v1.Interfaces;
using Forbury.Integrations.Helpers.Extensions;
using Microsoft.AspNetCore.Http.Extensions;
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Forbury.Integrations.API.v1.Services
{
    public abstract class ForburyApiClient : IForburyApiClient
    {
        protected readonly HttpClient _httpClient;

        public ForburyApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
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

        protected async Task CatchResponseFailure(HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode) return;

            var message = "An unknown error occurred while processing your request.";
            try
            {
                var forburyApiError = await response.Content.ReadAsObjectAsync<ForburyApiError>();
                message = forburyApiError.Message;
            } catch { }

            throw new ForburyApiException(message, response.StatusCode);
        }
    }
}
