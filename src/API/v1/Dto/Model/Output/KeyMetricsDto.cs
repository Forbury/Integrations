using Forbury.Integrations.Helpers.Converters;
using Newtonsoft.Json;

namespace Forbury.Integrations.API.v1.Dto.Model.Output
{
    public class KeyMetricsDto
    {
        public decimal RoundedAdoptedValuation { get; set; }
        public decimal AdditionalLandValue { get; set; }
        [JsonConverter(typeof(DecimalRoundingConverter), 6)] public decimal InitialPassingYield { get; set; }
        [JsonConverter(typeof(DecimalRoundingConverter), 6)] public decimal InitialPassingYieldFullyLeased { get; set; }
        [JsonConverter(typeof(DecimalRoundingConverter), 6)] public decimal EquivalentMarketYield { get; set; }
        [JsonConverter(typeof(DecimalRoundingConverter), 6)] public decimal EquivalentInitialYield { get; set; }
        [JsonConverter(typeof(DecimalRoundingConverter), 6)] public decimal EquivalentReversionaryYield { get; set; }
        [JsonConverter(typeof(DecimalRoundingConverter), 6)] public decimal TerminalYield { get; set; }
        [JsonConverter(typeof(DecimalRoundingConverter), 6)] public decimal TenYearIRR { get; set; }
        public decimal CapitalValuePsqm { get; set; }
        public decimal CapitalValueAdditionalLandPsqm { get; set; }
    }
}