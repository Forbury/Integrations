using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Forbury.Integrations.Helpers.Extensions
{
    public static class HttpContentExtensions
    {
        public static async Task<T> ReadAsObjectAsync<T>(this HttpContent httpContent)
        {
            string jsonString = await httpContent.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(jsonString);
        }
    }
}
