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
    public class ForburyModelApiClient : ForburyApiClient, IForburyModelApiClient
    {
        public ForburyModelApiClient(HttpClient httpClient) : 
            base(httpClient) 
        { }

        public async Task<PagedResult<ModelDto>> GetModels(DateTime? fromDate = null,
           ModelType? modelType = null,
           int amount = 20,
           int page = 1,
           CancellationToken cancellationToken = default)
        {
            QueryBuilder queryBuilder = GetPagedQueryBuilder(amount, page);
            if (fromDate != null) queryBuilder.Add("fromDate", fromDate.ToString());
            if (modelType != null) queryBuilder.Add("modelType", modelType.Value.ToString("d"));

            HttpResponseMessage response = await _httpClient.GetAsync($"{queryBuilder.ToQueryString()}", cancellationToken);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsObjectAsync<PagedResult<ModelDto>>();
        }

        public async Task<ModelDetailedDto> GetModelById(int modelId, 
            CancellationToken cancellationToken = default)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"{modelId}", cancellationToken);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsObjectAsync<ModelDetailedDto>();
        }
    }
}
