using System;
using System.Net.Http;
using System.Threading.Tasks;
using Forbury.Integrations.API.Interfaces;
using Forbury.Integrations.API.v1.Dto;
using Forbury.Integrations.API.v1.Dto.Enums;
using Forbury.Integrations.API.v1.Interfaces;
using Forbury.Integrations.Helpers.Extensions;
using IdentityModel.Client;
using Microsoft.AspNetCore.Http.Extensions;

namespace Forbury.Integrations.API.v1.Services
{
    public class ForburyApiService : IForburyApiService
    {
        private readonly HttpClient _httpClient;

        public ForburyApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<PagedResult<TeamDto>> GetTeams(int amount = 20, 
            int page = 1)
        {
            QueryBuilder queryBuilder = GetPagedQueryBuilder(amount, page);
            HttpResponseMessage response = await _httpClient.GetAsync($"team{queryBuilder.ToQueryString()}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsObjectAsync<PagedResult<TeamDto>>();
        }

        public async Task<PagedResult<ModelDto>> GetModelDataForTeam(int teamId, 
            DateTime? fromDate = null, 
            ModelType? modelType = null,
            int amount = 20,
            int page = 1)
        {
            QueryBuilder queryBuilder = GetPagedQueryBuilder(amount, page);
            if (fromDate != null) queryBuilder.Add("fromDate", fromDate.ToString());
            if (modelType != null) queryBuilder.Add("modelType", modelType.ToString());

            HttpResponseMessage response = await _httpClient.GetAsync($"team/{teamId}/model{queryBuilder.ToQueryString()}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsObjectAsync<PagedResult<ModelDto>>();
        }

        private QueryBuilder GetPagedQueryBuilder(int amount, int page)
        {
            return new QueryBuilder
            {
                { "amount", amount.ToString() },
                { "page", page.ToString() }
            };
        }
    }
}
