using System;
using System.Collections.Generic;
using Forbury.Integrations.API.v1.Dto.Model.Commercial.Input.Space.Review;
using Forbury.Integrations.Helpers.Converters;
using Newtonsoft.Json;

namespace Forbury.Integrations.API.v1.Dto.Model.Commercial.Input.Space.Renewal
{
    public class FirstRenewalDto
    {
        public string Type { get; set; }
        public string TenantName { get; set; }
        [JsonConverter(typeof(DateFormatConverter), JsonFormats.DateFormat)]
        public DateTime? StartDate { get; set; }
        public decimal? LeaseTermYears { get; set; }
        public bool? UseInWale { get; set; }

        public decimal? RenewalProbabilityPercent { get; set; }
        public decimal? RefurbPerMetreSquared { get; set; }
        public decimal? DowntimeMonths { get; set; }
        public decimal? IncentiveLumpSumPercent { get; set; }
        public decimal? IncentiveRentFreePercent { get; set; }
        public decimal? IncentiveRebatePercent { get; set; }
        public decimal? AppliedIncentivesPercent { get; set; }
        public decimal? LeasingCostsPercent { get; set; }

        public CommencementReviewDto CommencementRentReview { get; set; }
        public List<FirstRenewalReviewDto> RentReviews { get; set; }
    }
}
