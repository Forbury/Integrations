using Forbury.Integrations.API.v1.Clients;
using Forbury.Integrations.API.v1.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Forbury.Integrations.API.v1
{
    internal static class ServiceBuilder
    {
        internal static void AddForburyServices(IServiceCollection services, string uriPrefix)
        {
            services.AddForburyHttpClient<IForburyModelApiClient, ForburyModelApiClient>(uriPrefix, "model");
            services.AddForburyHttpClient<IForburyProductApiClient, ForburyProductApiClient>(uriPrefix, "product");
            services.AddForburyHttpClient<IForburyPropertyApiClient, ForburyPropertyApiClient>(uriPrefix, "property");
            services.AddForburyHttpClient<IForburyTeamApiClient, ForburyTeamApiClient>(uriPrefix, "team");
        }
    }
}
