using System.Threading;
using System.Threading.Tasks;
using Forbury.Integrations.API.v1.Dto.Model;
using Forbury.Integrations.API.v1.Dto.Model.Datum;
using Forbury.Integrations.API.v1.Dto.Model.Datum.Input;

namespace Forbury.Integrations.API.v1.Interfaces.Model
{
    public interface IForburyModelDatumApiClient : IForburyModelApiClient
    {
        Task<ModelDatumDetailedDto> GetModelById(int modelId,
            CancellationToken cancellationToken = default);

        Task<ModelDto> CreateModel(ModelDatumInputDto data,
            string googlePropertyId,
            int? teamId,
            CancellationToken cancellationToken = default);
    }
}
