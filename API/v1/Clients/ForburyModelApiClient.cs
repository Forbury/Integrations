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

            return await GetAsync<PagedResult<ModelDto>>($"{queryBuilder.ToQueryString()}", cancellationToken);
        }

        public async Task<ModelDetailedDto> GetModelById(int modelId, 
            CancellationToken cancellationToken = default)
        {
            return await GetAsync<ModelDetailedDto>($"{modelId}", cancellationToken);
        }
    }
}
