using System;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Forbury.Integrations.API.v1.Dto;
using Forbury.Integrations.API.v1.Dto.Enums;
using Forbury.Integrations.API.v1.Dto.File;
using Forbury.Integrations.API.v1.Dto.Model;
using Forbury.Integrations.API.v1.Interfaces.Model;
using Microsoft.AspNetCore.Http.Extensions;

namespace Forbury.Integrations.API.v1.Clients.Model
{
    public class ForburyModelApiClient : ForburyApiClient, IForburyModelApiClient
    {
        public ForburyModelApiClient(HttpClient httpClient) :
            base(httpClient)
        { }

        public async Task<PagedResult<ModelDto>> GetModels(ProductType? productType = null,
            DateTime? fromDate = null,
            ModelType? modelType = null,
            int amount = 20,
            int page = 1,
            CancellationToken cancellationToken = default)
        {
            QueryBuilder queryBuilder = GetPagedQueryBuilder(amount, page);
            if (fromDate.HasValue) queryBuilder.Add("fromDate", fromDate.ToString());
            if (productType.HasValue) queryBuilder.Add("productType", productType.Value.ToString("d"));
            if (modelType.HasValue) queryBuilder.Add("modelType", modelType.Value.ToString("d"));

            return await GetAsync<PagedResult<ModelDto>>($"{queryBuilder.ToQueryString()}", cancellationToken);
        }

        public async Task<PagedResult<ModelExtractionDto>> GetModelExtractionsById(int modelId,
            ModelExtractFileType? fileType = null,
            int amount = 20,
            int page = 1,
            CancellationToken cancellationToken = default)
        {
            QueryBuilder queryBuilder = GetPagedQueryBuilder(amount, page);
            if (fileType.HasValue) queryBuilder.Add("fileType", fileType.ToString());

            return await GetAsync<PagedResult<ModelExtractionDto>>($"{modelId}/extraction{queryBuilder.ToQueryString()}", cancellationToken);
        }

        public async Task<(Stream FileStream, string ContentType, string FileName)> DownloadModelExtraction(int modelId,
            string extractionId,
            CancellationToken cancellationToken = default)
        {
            return await GetFileAsync($"{modelId}/extraction/{extractionId}/download", cancellationToken);
        }

        public async Task<(Stream FileStream, string ContentType, string FileName)> DownloadModelBackup(int modelId,
            CancellationToken cancellationToken = default)
        {
            return await GetFileAsync($"{modelId}/backup/download", cancellationToken);
        }
    }
}
