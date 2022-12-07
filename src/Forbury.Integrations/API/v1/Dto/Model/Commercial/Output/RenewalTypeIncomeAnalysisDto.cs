namespace Forbury.Integrations.API.v1.Dto.Model.Commercial.Output
{
    public class RenewalTypeIncomeAnalysisDto : RenewalTypeDto
    {
        public decimal AverageGrossPassingPsqm { get; set; }
        public decimal AverageGrossMarketPsqm { get; set; }
        public decimal AverageNetPassingPsqm { get; set; }
        public decimal AverageNetMarketPsqm { get; set; }
    }
}