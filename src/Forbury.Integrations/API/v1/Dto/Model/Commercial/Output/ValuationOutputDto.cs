using Forbury.Integrations.API.v1.Dto.Model.Commercial.Output.ValuationMethods.Capitalisation;
using Forbury.Integrations.API.v1.Dto.Model.Commercial.Output.ValuationMethods.DiscountedCashflow;

namespace Forbury.Integrations.API.v1.Dto.Model.Commercial.Output
{
    public class ValuationOutputDto : IModelOutput
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
