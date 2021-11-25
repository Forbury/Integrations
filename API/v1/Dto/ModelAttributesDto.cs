using System;
using Forbury.Integrations.API.v1.Dto.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Forbury.Integrations.API.v1.Dto
{
    public class ModelAttributesDto
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public ModelType Type { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public string CreatedByEmail { get; set; }
        public int TeamId { get; set; }
        public string ExternalId { get; set; }
    }
}
