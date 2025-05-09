using System;
using System.Collections.Generic;
using Forbury.Integrations.API.v1.Dto.Model.Retail.Input.Enums;
using Forbury.Integrations.API.v1.Dto.Model.Retail.Input.Space.Incentives;
using Forbury.Integrations.API.v1.Dto.Model.Retail.Input.Space.Lease.MovingAnnualTurnover;
using Forbury.Integrations.API.v1.Dto.Model.Retail.Input.Space.Lease.PercentageRent;
using Forbury.Integrations.API.v1.Dto.Model.Retail.Input.Space.Recovery;
using Forbury.Integrations.API.v1.Dto.Model.Retail.Input.Space.Review;
using Forbury.Integrations.Helpers.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Forbury.Integrations.API.v1.Dto.Model.Retail.Input.Space.Lease
{
    public class LeaseDto
    {
        public decimal BaseRent { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public LeaseType LeaseType { get; set; }

        [JsonConverter(typeof(DateFormatConverter), JsonFormats.DateFormat)]
        public DateTime? StartDate { get; set; }
        [JsonConverter(typeof(DateFormatConverter), JsonFormats.DateFormat)]
        public DateTime? ExpiryDate { get; set; }

        public string TenantName { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public AgreementType AgreementType { get; set; }
        public string Industry { get; set; }
        public string SubIndustry { get; set; }
        public string ClassCode { get; set; }

        public bool IsHoldOver { get; set; }
        public int HoldOverMonths { get; set; }

        [JsonConverter(typeof(DateFormatConverter), JsonFormats.DateFormat)]
        public DateTime? BreakDate { get; set; }
        public string BreakPenalty { get; set; }
        [JsonConverter(typeof(DateFormatConverter), JsonFormats.DateFormat)]
        public DateTime? BreakNoticeDate { get; set; }

        public bool HeadOfAgreement { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public MakeGoodType MakeGood { get; set; }
        [JsonConverter(typeof(DateFormatConverter), JsonFormats.DateFormat)]
        public DateTime? HeadOfAgreementSignedDate { get; set; }
        [JsonConverter(typeof(DateFormatConverter), JsonFormats.DateFormat)]
        public DateTime? LeaseSignedDate { get; set; }
        public bool IsConfidential { get; set; }
        public bool IsConfirmed { get; set; }
        public string InformationSource { get; set; }
        public string Comments { get; set; }

        [JsonConverter(typeof(DateFormatConverter), JsonFormats.DateFormat)]
        public DateTime? PriorReviewDate { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public CarLevyType CarLevy { get; set; }

        public OutstandingIncentivesDto OutstandingIncentives { get; set; }
        public CommencementIncentivesDto CommencementIncentives { get; set; }

        public IncreaseOverBaseRecoveryDto IncreaseOverBaseRecoveries { get; set; }
        public NetRecoveryDto NetRecoveries { get; set; }
        public SemiGrossRecoveryDto SemiGrossRecoveries { get; set; }

        public List<RentReviewDto> RentReviews { get; set; }

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
        public int[] Options { get; set; }

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
