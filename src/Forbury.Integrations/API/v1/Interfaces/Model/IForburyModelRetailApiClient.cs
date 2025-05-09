using System.Threading;
using System.Threading.Tasks;
using Forbury.Integrations.API.v1.Dto.Model;
using Forbury.Integrations.API.v1.Dto.Model.Retail.Input;

namespace Forbury.Integrations.API.v1.Interfaces.Model
{
    public interface IForburyModelRetaillApiClient : IForburyModelApiClient
    {
        Task<ModelDto> CreateModel(ValuationInputDto data,
            string googlePropertyId,
            int? teamId,
            string externalId = null,
            string fullAddress = null,
            CancellationToken cancellationToken = default);
    }
}
