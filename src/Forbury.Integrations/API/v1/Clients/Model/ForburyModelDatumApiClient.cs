using Forbury.Integrations.API.Models.Configuration;
using Forbury.Integrations.API.v1.Dto.Model;
using Forbury.Integrations.API.v1.Dto.Model.Datum;
using Forbury.Integrations.API.v1.Dto.Model.Datum.Input;
using Forbury.Integrations.API.v1.Interfaces.Model;
using Microsoft.AspNetCore.Http.Extensions;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Forbury.Integrations.API.v1.Clients.Model
{
    public class ForburyModelDatumApiClient : ForburyModelApiClient, IForburyModelDatumApiClient
    {
        public ForburyModelDatumApiClient(HttpClient httpClient,
            ForburyConfiguration configuration) :
            base(httpClient, configuration)
        { }

        public async Task<ModelDatumDetailedDto> GetModelById(int modelId,
            CancellationToken cancellationToken = default)
        {
            return await GetAsync<ModelDatumDetailedDto>($"datum/{modelId}", cancellationToken);
        }

        public async Task<ModelDto> CreateModel(ModelDatumInputDto data,
            string googlePropertyId,
            int? teamId,
            string externalId = null,
            string fullAddress = null,
            CancellationToken cancellationToken = default)
        {
            QueryBuilder queryBuilder = new QueryBuilder();
            if (!string.IsNullOrEmpty(googlePropertyId)) queryBuilder.Add("googlePropertyId", googlePropertyId);
            if (teamId.HasValue) queryBuilder.Add("teamId", teamId.ToString());
            if (!string.IsNullOrEmpty(externalId)) queryBuilder.Add("externalId", externalId.ToString());
            if (!string.IsNullOrEmpty(fullAddress)) queryBuilder.Add("fullAddress", fullAddress.ToString());

            return await PostAsync<ModelDatumInputDto, ModelDto>($"datum/{queryBuilder.ToQueryString()}", data, cancellationToken);
        }
    }
}
