using System;
using System.Threading;
using System.Threading.Tasks;
using Forbury.Integrations.API.v1.Dto;
using Forbury.Integrations.API.v1.Dto.Enums;
using Forbury.Integrations.API.v1.Dto.Model;

namespace Forbury.Integrations.API.v1.Interfaces
{
    public interface IForburyModelApiClient
    {
        Task<PagedResult<ModelDto>> GetModels(DateTime? fromDate = null,
            ModelType? modelType = null,
            int amount = 20,
            int page = 1,
            CancellationToken cancellationToken = default);

        Task<ModelDetailedDto> GetModelById(int modelId,
            CancellationToken cancellationToken = default);
    }
}
