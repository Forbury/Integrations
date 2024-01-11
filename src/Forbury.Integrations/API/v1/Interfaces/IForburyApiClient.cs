using Forbury.Integrations.API.Models.Configuration;

namespace Forbury.Integrations.API.v1.Interfaces
{
    public interface IForburyApiClient
    {
        void SetClient(string name);
        void SetClient(string name, AuthenticationClientConfiguration clientConfiguration);
    }
}
