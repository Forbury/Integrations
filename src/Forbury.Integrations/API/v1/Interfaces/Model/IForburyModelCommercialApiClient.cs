using System.Threading;
using System.Threading.Tasks;
using Forbury.Integrations.API.v1.Dto.Model;

namespace Forbury.Integrations.API.v1.Interfaces.Model
{
    public interface IForburyModelCommercialApiClient : IForburyModelApiClient
    {
        Task<ModelDetailedDto> GetModelById(int modelId,
            CancellationToken cancellationToken = default);
    }
}
