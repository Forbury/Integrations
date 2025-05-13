using System.Collections.Generic;
using Forbury.Integrations.API.v1.Dto.Model.Commercial.Input.Future;

namespace Forbury.Integrations.API.v1.Dto.Model.Retail.Input.Future
{
    public class RetailRenewalAssumptionDto: RenewalAssumptionDto
    {
        /// <summary>
        /// Default Market Growth Rate for MAT & Rent
        /// </summary>
        public decimal? DefaultMarketGrowthRate { get; set; }

        /// <summary>
        /// Moving Annual Turnover Growth Rates by years (up to 20 years)
        /// </summary>
        public List<decimal?> MatGrowthRates { get; set; }

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
