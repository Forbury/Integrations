using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Forbury.Integrations.API.Models.Configuration;
using Forbury.Integrations.API.v1.Dto.Model.Commercial;
using Forbury.Integrations.API.v1.Interfaces.Model;
using Microsoft.Extensions.Options;

namespace Forbury.Integrations.API.v1.Clients.Model
{
    public class ForburyModelCommercialApiClient : ForburyModelApiClient, IForburyModelCommercialApiClient
    {
        public ForburyModelCommercialApiClient(HttpClient httpClient,
            IOptions<ForburyConfiguration> configuration) :
            base(httpClient, configuration)
        { }

        public async Task<ModelCommercialDetailedDto> GetModelById(int modelId,
            CancellationToken cancellationToken = default)
        {
            return await GetAsync<ModelCommercialDetailedDto>($"commercial/{modelId}", cancellationToken);
        }
    }
}
