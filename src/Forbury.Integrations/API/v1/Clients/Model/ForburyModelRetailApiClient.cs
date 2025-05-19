using Forbury.Integrations.API.Models.Configuration;
using Forbury.Integrations.API.v1.Dto.Model;
using Forbury.Integrations.API.v1.Interfaces.Model;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.Extensions.Options;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Forbury.Integrations.API.v1.Dto.Model.Retail.Input;

namespace Forbury.Integrations.API.v1.Clients.Model
{
    public class ForburyModelRetailApiClient : ForburyModelApiClient, IForburyModelRetaillApiClient
    {
        public ForburyModelRetailApiClient(HttpClient httpClient,
            IOptions<ForburyConfiguration> configuration) :
            base(httpClient, configuration)
        { }

        public async Task<ModelDto> CreateModel(RetailValuationInputDto data,
            string googlePropertyId,
            int? teamId,
            string externalId = null,
            string fullAddress = null,
            CancellationToken cancellationToken = default)
        {
            QueryBuilder queryBuilder = new QueryBuilder();
            if (!string.IsNullOrEmpty(googlePropertyId)) queryBuilder.Add("googlePropertyId", googlePropertyId);
            if (teamId.HasValue) queryBuilder.Add("teamId", teamId.ToString());
            if (!string.IsNullOrEmpty(externalId)) queryBuilder.Add("externalId", externalId);
            if (!string.IsNullOrEmpty(fullAddress)) queryBuilder.Add("fullAddress", fullAddress);

            return await PostAsync<RetailValuationInputDto, ModelDto>($"retail/{queryBuilder.ToQueryString()}", data, cancellationToken);
        }
    }
}
