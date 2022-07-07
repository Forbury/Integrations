using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Forbury.Integrations.API.v1.Dto;
using Forbury.Integrations.API.v1.Dto.Enums;
using Forbury.Integrations.API.v1.Interfaces;
using Forbury.Integrations.Helpers.Extensions;
using Microsoft.AspNetCore.Http.Extensions;

namespace Forbury.Integrations.API.v1.Services
{
    public class ForburyTeamApiClient : ForburyApiClient, IForburyTeamApiClient
    {
        public ForburyTeamApiClient(HttpClient httpClient) :
            base(httpClient)
        { }

        public async Task<PagedResult<TeamDto>> GetTeams(int amount = 20, 
            int page = 1,
            CancellationToken cancellationToken = default)
        {
            QueryBuilder queryBuilder = GetPagedQueryBuilder(amount, page);
            HttpResponseMessage response = await _httpClient.GetAsync($"{queryBuilder.ToQueryString()}", cancellationToken);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsObjectAsync<PagedResult<TeamDto>>();
        }

        public async Task<TeamDetailedDto> GetTeamById(int teamId, 
            CancellationToken cancellationToken = default)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"{teamId}", cancellationToken);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsObjectAsync<TeamDetailedDto>();
        }

        public async Task<PagedResult<ModelDto>> GetModelsByTeamId(int teamId, 
            DateTime? fromDate = null, 
            ModelType? modelType = null,
            int amount = 20,
            int page = 1,
            CancellationToken cancellationToken = default)
        {
            QueryBuilder queryBuilder = GetPagedQueryBuilder(amount, page);
            if (fromDate != null) queryBuilder.Add("fromDate", fromDate.ToString());
            if (modelType != null) queryBuilder.Add("modelType", modelType.Value.ToString("d"));

            HttpResponseMessage response = await _httpClient.GetAsync($"{teamId}/model{queryBuilder.ToQueryString()}", cancellationToken);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsObjectAsync<PagedResult<ModelDto>>();
        }

        public async Task<ModelDetailedDto> GetModelByTeamId(int teamId, 
            int modelId, 
            CancellationToken cancellationToken = default)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"{teamId}/model/{modelId}", cancellationToken);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsObjectAsync<ModelDetailedDto>();
        }

        public async Task<PagedResult<PropertyDto>> GetPropertiesByTeamId(int teamId, 
            int amount = 20, 
            int page = 1, 
            CancellationToken cancellationToken = default)
        {
            QueryBuilder queryBuilder = GetPagedQueryBuilder(amount, page);

            HttpResponseMessage response = await _httpClient.GetAsync($"{teamId}/property{queryBuilder.ToQueryString()}", cancellationToken);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsObjectAsync<PagedResult<PropertyDto>>();
        }

        public async Task<PropertyDetailedDto> GetPropertyByTeamId(int teamId, 
            int propertyId, 
            CancellationToken cancellationToken = default)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"{teamId}/property/{propertyId}", cancellationToken);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsObjectAsync<PropertyDetailedDto>();
        }
    }
}
