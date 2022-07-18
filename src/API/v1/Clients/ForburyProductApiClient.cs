using System.Collections.Generic;
using System.IO;
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
    public class ForburyProductApiClient : ForburyApiClient, IForburyProductApiClient
    {
        public ForburyProductApiClient(HttpClient httpClient) :
            base(httpClient)
        { }

        public async Task<List<ProductDto>> GetProducts(CancellationToken cancellationToken = default)
        {
            return await GetAsync<List<ProductDto>>(string.Empty, cancellationToken);
        }

        public async Task<(Stream FileStream, string ContentType, string FileName)> DownloadProduct(ProductType productType, 
            string googlePropertyId = null, 
            string externalId = null, 
            int? modelId = null, 
            CancellationToken cancellationToken = default)
        {
            var queryBuilder = new QueryBuilder();
            if (!string.IsNullOrEmpty(googlePropertyId)) queryBuilder.Add("googlePropertyId", googlePropertyId);
            if (!string.IsNullOrEmpty(externalId)) queryBuilder.Add("externalId", externalId);
            if (modelId.HasValue) queryBuilder.Add("modelId", modelId.ToString());

            HttpResponseMessage response = await _httpClient.GetAsync($"{productType.ToString("d")}/download{queryBuilder.ToQueryString()}", cancellationToken);
            await CatchResponseFailure(response);
            return (await response.Content.ReadAsStreamAsync(), response.Content.Headers.ContentType.MediaType, response.Content.Headers.ContentDisposition.FileNameStar);
        }
    }
}
