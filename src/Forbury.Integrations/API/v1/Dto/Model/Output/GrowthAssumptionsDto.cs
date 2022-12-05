using Forbury.Integrations.Helpers.Converters;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Forbury.Integrations.API.v1.Dto.Model.Output
{
    public class GrowthAssumptionsDto
    {
        public List<RenewalTypeGrowthDto> RenewalTypeGrowths { get; set; }
        [JsonConverter(typeof(DecimalRoundingConverter), 6)] public decimal GrossMarketIncomeTenYearCAGR { get; set; }
        [JsonConverter(typeof(DecimalRoundingConverter), 6)] public decimal OutgoingsTenYearCAGR { get; set; }
        [JsonConverter(typeof(DecimalRoundingConverter), 6)] public decimal CPITenYearCAGR { get; set; }
    }
}
