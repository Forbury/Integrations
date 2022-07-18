using Forbury.Integrations.API.v1.Dto.Input.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;

namespace Forbury.Integrations.API.v1.Dto.Input.Future
{
    public class FuturesDto
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public CalendarBasis MarketYearBasis { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public CalendarBasis OutgoingsYearBasis { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public CalendarBasis EscalationYearBasis { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public GrowthBasis MarketRentGrowthBasis { get; set; }
        public decimal? PriorYearCpi { get; set; }
        public bool? DeferOutgoings { get; set; }
        public List<GrowthAssumptionDto> EscalationAssumptions { get; set; }
        public List<GrowthAssumptionDto> MarketGrowthAssumptions { get; set; }
        public List<RenewalAssumptionDto> RenewalAssumptions { get; set; }
    }
}
