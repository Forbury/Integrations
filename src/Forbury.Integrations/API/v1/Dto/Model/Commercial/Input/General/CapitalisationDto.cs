using Forbury.Integrations.API.v1.Dto.Model.Commercial.Input.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Forbury.Integrations.API.v1.Dto.Model.Commercial.Input.General
{   
    public class CapitalisationDto
    {
        public string RefurbGrowthRate { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public ReversionType DefaultReversionType { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public RateType StepReversionsAppliedRateType { get; set; }

        public bool? StepReversionInflateMarketRent { get; set; }
    }
}
