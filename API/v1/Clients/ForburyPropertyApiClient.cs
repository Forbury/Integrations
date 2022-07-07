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
    public class ForburyPropertyApiClient : ForburyApiClient, IForburyPropertyApiClient
    {
        public ForburyPropertyApiClient(HttpClient httpClient) :
            base(httpClient)
        { }

        public async Task<PagedResult<PropertyDto>> GetProperties(int amount = 20, 
            int page = 1, 
            CancellationToken cancellationToken = default)
        {
            QueryBuilder queryBuilder = GetPagedQueryBuilder(amount, page);

            HttpResponseMessage response = await _httpClient.GetAsync($"{queryBuilder.ToQueryString()}", cancellationToken);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsObjectAsync<PagedResult<PropertyDto>>();
        }

        public async Task<PropertyDetailedDto> GetPropertyById(int propertyId, 
            CancellationToken cancellationToken = default)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"{propertyId}", cancellationToken);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsObjectAsync<PropertyDetailedDto>();
        }

        public async Task<PagedResult<ModelDto>> GetModelsByPropertyId(int propertyId, 
            DateTime? fromDate = null, 
            ModelType? modelType = null, 
            int amount = 20, 
            int page = 1, 
            CancellationToken cancellationToken = default)
        {
            QueryBuilder queryBuilder = GetPagedQueryBuilder(amount, page);
            if (fromDate != null) queryBuilder.Add("fromDate", fromDate.ToString());
            if (modelType != null) queryBuilder.Add("modelType", modelType.Value.ToString("d"));

            HttpResponseMessage response = await _httpClient.GetAsync($"{propertyId}/model{queryBuilder.ToQueryString()}", cancellationToken);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsObjectAsync<PagedResult<ModelDto>>();
        }

        public async Task<ModelDetailedDto> GetModelByPropertyId(int propertyId, 
            int modelId, 
            CancellationToken cancellationToken = default)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"{propertyId}/model/{modelId}", cancellationToken);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsObjectAsync<ModelDetailedDto>();
        }
    }
}
