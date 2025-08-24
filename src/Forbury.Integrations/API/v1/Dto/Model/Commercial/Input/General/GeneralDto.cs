using Forbury.Integrations.API.v1.Dto.Enums;
using Forbury.Integrations.Helpers.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Forbury.Integrations.API.v1.Dto.Model.Commercial.Input.Enums;

namespace Forbury.Integrations.API.v1.Dto.Model.Commercial.Input.General
{
    public class GeneralDto : IValidatableObject
    {
        [JsonConverter(typeof(DateFormatConverter), JsonFormats.DateFormat)]
        public DateTime? ValuationDate { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public ValuationType ValuationType { get; set; }
        public string ValuationMethod { get; set; } 
        public decimal? RoundedAdoptedValue { get; set; }
        public decimal? AdoptedValueAdjustment { get; set; }
        public decimal? CapRateInitial { get; set; }
        public decimal? CapRateMarket { get; set; }
        public decimal? CapRateTerminalBps { get; set; }
        public decimal? InterestValued { get; set; }
        public string IncentiveBasis { get; set; }
        public decimal? ExpiryAllowanceMonths { get; set; }
        public decimal? TerminalExpiryAllowanceMonths { get; set; }
        public decimal? DiscountRate { get; set; }
        public decimal? CapRateTerminal { get; set; }
        public int CashFlowPeriod { get; set; }
        public decimal? BudgetedCapexAllowanceMonths { get; set; }
        public decimal? SinkingFundAllowanceMonths { get; set; }
        [JsonConverter(typeof(DateFormatConverter), JsonFormats.DateFormat)]
        [DisplayName("Leasehold Expiry")]
        public DateTime? LeaseholdExpiryDate { get; set; }
        
        public string HistoricalCpiSource { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public GrowthBasisType LeasingCostsBasis { get; set; }
        public decimal? DefaultReviewFrequency { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public RateType LumpSumAppliedRateType { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public RateType RebateAppliedRateType { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public RateType RentFreeAppliedRateType { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public VacancyRateType ExistingVacancyRateType { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public DiscountType ExpiryAllowanceDiscountType { get; set; }
        public CapitalisationDto Capitalisation { get; set; }
        public DiscountedCashflowDto DiscountedCashflow { get; set; }
        public AcquisitionCostDto AcquisitionCost { get; set; }
        public List<decimal?> UpperBound { get; set; }
        public List<decimal?> ROUNDING { get; set; }
        public List<decimal?>  StampDuties { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (ValuationType == ValuationType.Freehold && LeaseholdExpiryDate.HasValue)
            {
                yield return new ValidationResult(
                    "LeaseholdExpiry should not be set for Freehold valuations.",
                    new[] { nameof(LeaseholdExpiryDate) });
            }
        }
    }
}
