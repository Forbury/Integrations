using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Forbury.Integrations.API.v1.Dto;
using Forbury.Integrations.API.v1.Dto.Enums;
using Forbury.Integrations.API.v1.Dto.File;
using Forbury.Integrations.API.v1.Dto.Model;

namespace Forbury.Integrations.API.v1.Interfaces.Model
{
    public interface IForburyModelApiClient : IForburyApiClient
    {
        Task<PagedResult<ModelDto>> GetModels(DateTime? fromDate = null,
            ModelType? modelType = null,
            int amount = 20,
            int page = 1,
            CancellationToken cancellationToken = default);

        Task<PagedResult<ModelExtractionDto>> GetModelExtractionsById(int modelId,
            ModelExtractFileType? fileType = null,
            int amount = 20,
            int page = 1,
            CancellationToken cancellationToken = default);

        Task<(Stream FileStream, string ContentType, string FileName)> DownloadModelExtraction(int modelId,
            string extractionId,
            CancellationToken cancellationToken = default);

        Task<(Stream FileStream, string ContentType, string FileName)> DownloadModelBackup(int modelId,
            CancellationToken cancellationToken = default);
    }
}
