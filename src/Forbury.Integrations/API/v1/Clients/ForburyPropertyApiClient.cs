using Forbury.Integrations.API.Models.Configuration;
using Forbury.Integrations.API.v1.Dto;
using Forbury.Integrations.API.v1.Dto.Enums;
using Forbury.Integrations.API.v1.Dto.Model;
using Forbury.Integrations.API.v1.Dto.Property;
using Forbury.Integrations.API.v1.Interfaces;
using Microsoft.AspNetCore.Http.Extensions;
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Forbury.Integrations.API.v1.Clients
{
    public class ForburyPropertyApiClient : ForburyApiClient, IForburyPropertyApiClient
    {
        public ForburyPropertyApiClient(HttpClient httpClient,
            ForburyConfiguration configuration) :
            base(httpClient, configuration)
        { }

        public async Task<PagedResult<PropertyDto>> GetProperties(int amount = 20,
            int page = 1,
            CancellationToken cancellationToken = default)
        {
            QueryBuilder queryBuilder = GetPagedQueryBuilder(amount, page);

            return await GetAsync<PagedResult<PropertyDto>>($"{queryBuilder.ToQueryString()}", cancellationToken);
        }

        public async Task<PropertyDetailedDto> GetPropertyById(int propertyId,
            CancellationToken cancellationToken = default)
        {
            return await GetAsync<PropertyDetailedDto>($"{propertyId}", cancellationToken);
        }

        public async Task<PagedResult<ModelDto>> GetModelsByPropertyId(int propertyId,
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

            return await GetAsync<PagedResult<ModelDto>>($"{propertyId}/model{queryBuilder.ToQueryString()}", cancellationToken);
        }
    }
}
