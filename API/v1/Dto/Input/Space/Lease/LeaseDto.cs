using System;
using System.Collections.Generic;
using Forbury.Integrations.API.v1.Dto.Input.Enums;
using Forbury.Integrations.API.v1.Dto.Input.Space.Incentives;
using Forbury.Integrations.API.v1.Dto.Input.Space.Recovery;
using Forbury.Integrations.API.v1.Dto.Input.Space.Review;
using Forbury.Integrations.Helpers.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Forbury.Integrations.API.v1.Dto.Input.Space.Lease
{
    public class LeaseDto
    {
        public decimal BaseRent { get; set; }
        
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

        public string Options { get; set; }
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
    }
}
