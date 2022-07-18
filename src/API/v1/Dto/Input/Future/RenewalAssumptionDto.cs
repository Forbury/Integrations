using System;
using System.Collections.Generic;
using System.Text;

namespace Forbury.Integrations.API.v1.Dto.Input.Future
{
    public class RenewalAssumptionDto
    {
        public string Name { get; set; }
        public decimal? VacantDowntimeMonths { get; set; }
        public decimal? RenewalProbabilityPercent { get; set; }
        public int? NewLeaseYears { get; set; }
        public int? NewLeaseReviewYears { get; set; }
        public string NewLeaseStructure { get; set; }
        public decimal? FutureDowntimeMonths { get; set; }
        public decimal? IncentivesPercent { get; set; }
        public decimal? IncentivesProbabilityPercent { get; set; }
        public decimal? LeasingCostsRenewingPercent { get; set; }
        public decimal? LeasingCostsNewPercent { get; set; }
        public decimal? RefurbAllowanceRenewing { get; set; }
        public decimal? RefurbAllowanceNew { get; set; }
        public decimal? MarketCapRate { get; set; }
        public List<decimal?> NewLeaseIncentives { get; set; }
        public List<decimal?> IncentiveProbabilityPercentages { get; set; }
    }
}
