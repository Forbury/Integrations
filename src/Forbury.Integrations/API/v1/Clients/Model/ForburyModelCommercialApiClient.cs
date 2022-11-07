using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Forbury.Integrations.API.v1.Dto.Model;
using Forbury.Integrations.API.v1.Interfaces.Model;

namespace Forbury.Integrations.API.v1.Clients.Model
{
    public class ForburyModelCommercialApiClient : ForburyModelApiClient, IForburyModelCommercialApiClient
    {
        public ForburyModelCommercialApiClient(HttpClient httpClient) :
            base(httpClient)
        { }

        public async Task<ModelDetailedDto> GetModelById(int modelId,
            CancellationToken cancellationToken = default)
        {
            return await GetAsync<ModelDetailedDto>($"{modelId}", cancellationToken);
        }
    }
}
