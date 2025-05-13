using Forbury.Integrations.API.v1.Dto.Model.Commercial.Input.Space.Renewal;
using Forbury.Integrations.API.v1.Dto.Model.Retail.Input.Space.Lease.PercentageRent;

namespace Forbury.Integrations.API.v1.Dto.Model.Retail.Input.Space.Lease
{
    public class RetailLeaseDto: Commercial.Input.Space.Lease.LeaseDto
    {
        /// <summary>
        /// The MAT amount prior 12 months (GST inclusive/exclusive based on General.MAT.Prior12MonthsGstInclusive)
        /// </summary>
        public decimal? MATPrior12Months { get; set; }

        /// <summary>
        /// The MAT amount last 12 months (GST inclusive/exclusive based on General.MAT.Prior12MonthsGstInclusive)
        /// </summary>
        public decimal? MATLast12Months { get; set; }

        /// <summary>
        /// Provide up to 3 future options periods in years
        /// </summary>
        public new int[] Options { get; set; }

        /// <summary>
        /// The selected option index (0, 1, 2) zero based index, translated into 1, 2, 3 for the model.
        /// </summary>
        public int? AdoptedOption { get; set; }

        /// <summary>
        /// GOC Cap deal until first review
        /// </summary>
        public decimal? GocCap { get; set; }

        /// <summary>
        /// Review frequency in years
        /// </summary>
        public int? DefaultReviewFrequency { get; set; }

        /// <summary>
        /// Review type (e.g. Fixed % such as 2.5%, CPI, CPI+1.25, %RentAvg2Y, GOC8.5%)
        /// </summary>
        public string DefaultReviewType { get; set; }

        public PercentageRentDto PercentageRent { get; set; }
    }
}
