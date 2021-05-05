using Forbury.Integrations.API.v1.Dto.Input.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Forbury.Integrations.API.v1.Dto.Input.Space.Recovery
{
    public class RecoveryDto
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public RecoveryLeaseType Type { get; set; }
    }
}
