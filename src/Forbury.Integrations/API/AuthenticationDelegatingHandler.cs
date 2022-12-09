using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Forbury.Integrations.API.Interfaces;
using IdentityModel.Client;

namespace Forbury.Integrations.API
{
    internal class AuthorizationDelegatingHandler : DelegatingHandler
    {
        private readonly IForburyAuthenticationService _forburyAuthenticationService;

        public AuthorizationDelegatingHandler(IForburyAuthenticationService forburyAuthenticationService)
        {
            _forburyAuthenticationService = forburyAuthenticationService;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            string clientName = request.Headers.Contains(Constants.ClientHeaderName) ?
                request.Headers.GetValues(Constants.ClientHeaderName).FirstOrDefault() : null;
            string accessToken = await _forburyAuthenticationService.GetAccessTokenAsync(cancellationToken, clientName);
            request.SetBearerToken(accessToken);
            return await base.SendAsync(request, cancellationToken);
        }
    }
}
