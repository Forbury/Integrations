using Forbury.Integrations.API.v1.Dto.Model.Output.ValuationMethods.Capitalisation;
using Forbury.Integrations.API.v1.Dto.Model.Output.ValuationMethods.DiscountedCashflow;

namespace Forbury.Integrations.API.v1.Dto.Model.Output
{
    public class ValuationOutputDto
    {
        public KeyMetricsDto KeyMetrics { get; set; }
        public IncomeAnalysisDto IncomeAnalysis { get; set; }
        public OccupancyAreaDto OccupancyArea { get; set; }
        public CapitalisationDto Capitalisation { get; set; }
        public DiscountedCashflowDto DiscountedCashflow { get; set; }
        public GrowthAssumptionsDto GrowthAssumptions { get; set; }
        public CapexAssumptionsDto CapexAssumptions { get; set; }
    }
}
