using System.Threading;
using System.Threading.Tasks;
using Forbury.Integrations.API.Models;

namespace Forbury.Integrations.API.Interfaces
{
    public interface IForburyAuthenticationService
    {
        Task<string> GetAccessTokenAsync(CancellationToken cancellationToken, string client = null);
    }
}
