using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using Forbury.Integrations.API.Interfaces;

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
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            return await base.SendAsync(request, cancellationToken);
        }
    }
}
