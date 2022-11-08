using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Forbury.Integrations.API.v1.Dto.Model;
using Forbury.Integrations.API.v1.Dto.Model.Datum;
using Forbury.Integrations.API.v1.Dto.Model.Datum.Input;
using Forbury.Integrations.API.v1.Interfaces.Model;
using Microsoft.AspNetCore.Http.Extensions;

namespace Forbury.Integrations.API.v1.Clients.Model
{
    public class ForburyModelDatumApiClient : ForburyModelApiClient, IForburyModelDatumApiClient
    {
        public ForburyModelDatumApiClient(HttpClient httpClient) :
            base(httpClient)
        { }

        public async Task<ModelDatumDetailedDto> GetModelById(int modelId,
            CancellationToken cancellationToken = default)
        {
            return await GetAsync<ModelDatumDetailedDto>($"datum/{modelId}", cancellationToken);
        }

        public async Task<ModelDto> CreateModel(ModelDatumInputDto data,
            string googlePropertyId,
            int? teamId,
            CancellationToken cancellationToken = default)
        {
            QueryBuilder queryBuilder = new QueryBuilder();
            queryBuilder.Add("googlePropertyId", googlePropertyId);
            if (teamId != null) queryBuilder.Add("teamId", teamId.ToString());

            return await PostAsync<ModelDatumInputDto, ModelDto>($"datum/{queryBuilder.ToQueryString()}", data, cancellationToken);
        }
    }
}
