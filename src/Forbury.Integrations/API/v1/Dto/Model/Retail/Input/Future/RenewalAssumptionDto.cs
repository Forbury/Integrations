using System.Collections.Generic;

namespace Forbury.Integrations.API.v1.Dto.Model.Retail.Input.Future
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

        /// <summary>
        /// Default Market Growth Rate for MAT & Rent
        /// </summary>
        public decimal? DefaultMarketGrowthRate { get; set; }

        /// <summary>
        /// Moving Annual Turnover Growth Rates by years (up to 20 years)
        /// </summary>
        public List<decimal?> MATGrowthRates { get; set; }

        /// <summary>
        /// Number of months of incentive for renewing lease
        /// </summary>
        public decimal? IncentiveRenewingMonths { get; set; }

        /// <summary>
        /// Number of months of incentive for new lease
        /// </summary>
        public decimal? IncentiveNewLeaseMonths { get; set; }
    }
}
