namespace Forbury.Integrations.API.v1.Dto.Model.Output
{
    public class RenewalTypeGrowthDto : RenewalTypeDto
    {
        public decimal GrossMarketFaceTenYearCAGR { get; set; }
        public decimal NetMarketFaceTenYearCAGR { get; set; }
        public decimal GrossMarketEffectiveTenYearCAGR { get; set; }
        public decimal NetMarketEffectiveTenYearCAGR { get; set; }
    }
}
