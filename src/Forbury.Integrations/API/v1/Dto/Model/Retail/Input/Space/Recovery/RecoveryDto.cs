using Forbury.Integrations.API.v1.Dto.Model.Retail.Input.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Forbury.Integrations.API.v1.Dto.Model.Retail.Input.Space.Recovery
{
    public class RecoveryDto
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public RecoveryLeaseType Type { get; set; }
    }
}
