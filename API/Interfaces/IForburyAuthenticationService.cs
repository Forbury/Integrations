using System.Threading.Tasks;
using Forbury.Integrations.API.Models;

namespace Forbury.Integrations.API.Interfaces
{
    public interface IForburyAuthenticationService
    {
        Task<TokenResponse> GetAccessTokenAsync();
    }
}
