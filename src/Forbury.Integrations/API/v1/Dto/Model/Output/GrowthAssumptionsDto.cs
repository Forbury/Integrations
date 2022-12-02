using System.Collections.Generic;

namespace Forbury.Integrations.API.v1.Dto.Model.Output
{
    public class GrowthAssumptionsDto
    {
        public List<RenewalTypeGrowthDto> RenewalTypeGrowths { get; set; }
        public decimal GrossMarketIncomeTenYearCAGR { get; set; }
        public decimal OutgoingsTenYearCAGR { get; set; }
        public decimal CPITenYearCAGR { get; set; }
    }
}
