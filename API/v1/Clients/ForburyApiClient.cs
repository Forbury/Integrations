using Forbury.Integrations.API.v1.Interfaces;
using Forbury.Integrations.Helpers.Extensions;
using Microsoft.AspNetCore.Http.Extensions;
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
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsObjectAsync<TResult>();
        }
    }
}
