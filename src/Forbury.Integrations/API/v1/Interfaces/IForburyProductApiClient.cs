using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Forbury.Integrations.API.v1.Dto.Enums;
using Forbury.Integrations.API.v1.Dto.Product;

namespace Forbury.Integrations.API.v1.Interfaces
{
    public interface IForburyProductApiClient
    {
        Task<List<ProductDto>> GetProducts(CancellationToken cancellationToken = default);

        Task<(Stream FileStream, string ContentType, string FileName)> DownloadProduct(ProductType productType,
            string googlePropertyId = null,
            string externalId = null,
            int? modelId = null,
            CancellationToken cancellationToken = default);
    }
}
