using System;
using Newtonsoft.Json;

namespace Forbury.Integrations.API.Models
{
    public class TokenResponse
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }
        [JsonProperty("expires_in")]
        public int ExpiresIn { get; set; }
        [JsonProperty("token_type")]
        public string TokenType { get; set; }
        [JsonProperty("scope")]
        public string Scope { get; set; }

        [JsonIgnore] 
        public DateTime CreatedOn { get; } = DateTime.Now;
        [JsonIgnore] 
        public DateTime ExpiresOn => CreatedOn.AddSeconds(ExpiresIn);
    }
}
