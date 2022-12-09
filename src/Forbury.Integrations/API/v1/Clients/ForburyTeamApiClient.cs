using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Forbury.Integrations.API.v1.Dto;
using Forbury.Integrations.API.v1.Dto.Enums;
using Forbury.Integrations.API.v1.Dto.Model;
using Forbury.Integrations.API.v1.Dto.Property;
using Forbury.Integrations.API.v1.Dto.Team;
using Forbury.Integrations.API.v1.Interfaces;
using Microsoft.AspNetCore.Http.Extensions;

namespace Forbury.Integrations.API.v1.Clients
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
            ProductType? productType = null,
            DateTime? fromDate = null,
            ModelType? modelType = null,
            int amount = 20,
            int page = 1,
            CancellationToken cancellationToken = default)
        {
            QueryBuilder queryBuilder = GetPagedQueryBuilder(amount, page);
            if (fromDate.HasValue) queryBuilder.Add("fromDate", fromDate.ToString());
            if (productType.HasValue) queryBuilder.Add("productType", modelType.Value.ToString("d"));
            if (modelType.HasValue) queryBuilder.Add("modelType", modelType.Value.ToString("d"));

            return await GetAsync<PagedResult<ModelDto>>($"{teamId}/model{queryBuilder.ToQueryString()}", cancellationToken);
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
