using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Forbury.Integrations.API.v1.Dto;
using Forbury.Integrations.API.v1.Dto.Enums;
using Forbury.Integrations.API.v1.Interfaces;
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

            return await GetAsync<PagedResult<TeamDto>>($"{queryBuilder.ToQueryString()}", cancellationToken);
        }

        public async Task<TeamDetailedDto> GetTeamById(int teamId, 
            CancellationToken cancellationToken = default)
        {
            return await GetAsync<TeamDetailedDto>($"{teamId}", cancellationToken);
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

            return await GetAsync<PagedResult<ModelDto>>($"{teamId}/model{queryBuilder.ToQueryString()}", cancellationToken);
        }

        public async Task<ModelDetailedDto> GetModelByTeamId(int teamId, 
            int modelId, 
            CancellationToken cancellationToken = default)
        {
            return await GetAsync<ModelDetailedDto>($"{teamId}/model/{modelId}", cancellationToken);
        }

        public async Task<PagedResult<PropertyDto>> GetPropertiesByTeamId(int teamId, 
            int amount = 20, 
            int page = 1, 
            CancellationToken cancellationToken = default)
        {
            QueryBuilder queryBuilder = GetPagedQueryBuilder(amount, page);

            return await GetAsync<PagedResult<PropertyDto>>($"{teamId}/property{queryBuilder.ToQueryString()}", cancellationToken);
        }

        public async Task<PropertyDetailedDto> GetPropertyByTeamId(int teamId, 
            int propertyId, 
            CancellationToken cancellationToken = default)
        {
            return await GetAsync<PropertyDetailedDto>($"{teamId}/property/{propertyId}", cancellationToken);
        }
    }
}
