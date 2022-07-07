using Forbury.Integrations.API.v1.Interfaces;
using Microsoft.AspNetCore.Http.Extensions;
using System.Net.Http;

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
    }
}
