using Forbury.Integrations.API.v1.Dto.Output.ValuationMethods.Capitalisation;
using Forbury.Integrations.API.v1.Dto.Output.ValuationMethods.DiscountedCashflow;

namespace Forbury.Integrations.API.v1.Dto.Output
{
    public class ValuationOutputDto
    {
        public KeyMetricsDto KeyMetrics { get; set; }
        public IncomeAnalysisDto IncomeAnalysis { get; set; }
        public OccupancyAreaDto OccupancyArea { get; set; }
        public CapitalisationDto Capitalisation { get; set; }
        public DiscountedCashflowDto DiscountedCashflow { get; set; }
    }
}
