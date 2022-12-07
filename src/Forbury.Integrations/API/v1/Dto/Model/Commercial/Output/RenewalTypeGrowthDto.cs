using Forbury.Integrations.Helpers.Converters;
using Newtonsoft.Json;

namespace Forbury.Integrations.API.v1.Dto.Model.Commercial.Output
{
    public class RenewalTypeGrowthDto : RenewalTypeDto
    {
        [JsonConverter(typeof(DecimalRoundingConverter), 6)] public decimal GrossMarketFaceTenYearCAGR { get; set; }
        [JsonConverter(typeof(DecimalRoundingConverter), 6)] public decimal NetMarketFaceTenYearCAGR { get; set; }
        [JsonConverter(typeof(DecimalRoundingConverter), 6)] public decimal GrossMarketEffectiveTenYearCAGR { get; set; }
        [JsonConverter(typeof(DecimalRoundingConverter), 6)] public decimal NetMarketEffectiveTenYearCAGR { get; set; }
    }
}
