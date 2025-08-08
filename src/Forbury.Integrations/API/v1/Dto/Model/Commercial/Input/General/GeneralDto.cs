using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Forbury.Integrations.API.v1.Dto.Enums;
using Forbury.Integrations.API.v1.Dto.Model.Commercial.Input.General.Incentives;
using Forbury.Integrations.Helpers.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Forbury.Integrations.API.v1.Dto.Model.Commercial.Input.General
{
    public class GeneralDto : IValidatableObject
    {
        [JsonConverter(typeof(DateFormatConverter), JsonFormats.DateFormat)]
        public DateTime? ValuationDate { get; set; } // RESTORE_ValDate - Date of Valuation
        [JsonConverter(typeof(StringEnumConverter))]
        public ValuationType ValuationType { get; set; } // RESTORE_ValType - Valuation Interest Type
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
        public DateTime? LeaseholdExpiryDate { get; set; } //RESTORE_LHexpiry - Date of Lease Expiry
        public HistoricalCpiSource HistoricalCpiSource { get; set; } // RESTORE_CPI_source - Historical CPI Source

        public FutureIncentivesDto? FutureIncentives { get; set; }
        //public decimal? General_FutureIncentiveLumpSum { get; set; } //RESTORE_General_FutureIncentiveLumpSum - Default Proportion of Future Incentives treated as lump sum
        //public decimal? General_FutureIncentivesRentFree { get; set; } //Restore_FutureIncentivesRentFree - Default Proportion of Future Incentives treated as rent free
        public string Basis_LeasingCosts { get; set; } //RESTORE_Basis_LeasingCosts - Input rent basis for % lease cost calculations - (Enum - Net and Gross)
        public decimal? RevFreqDefault { get; set; } //RESTORE_RevFreqDefault - Default Review Frequency
        public string LumSumAppliedRate { get; set; } //RESTORE_LumSumAppliedRate - Lump Sum Payments - Apply Cap Rate or Discount Rate -(Enum - Cap Rate or Discount Rate)
        public string RebateAppliedRate { get; set; } //RESTORE_RebateAppliedRate - Rebates - Apply Cap Rate or Discount Rate -(Enum - Cap Rate or Discount Rate)
        public string RentFreeAppliedRate { get; set; } //RESTORE_RentFreeAppliedRate - Rent Free Periods - Apply Cap Rate or Discount Rate -(Enum - Cap Rate or Discount Rate)
        public string ExistingVacancyRate { get; set; } //RESTORE_ExistingVacancyRate - Discount rate applied to existing vacancy allowances -(Enum - None, Cap Rate or Discount Rate)
        public decimal? ExpiryAllowanceWindow_CAP { get; set; } // RESTORE_ExpiryAllowanceWindow_CAP - CAP VALUATION - Make expiry allowances for tenancies expiring within - (Any integer between 0 to 60)
        public string ExpiryAllowanceWindow_Discount { get; set; } // RESTORE_ExpiryAllowanceWindow_Discount - Discounted expiries falling within first 12 months - (Enum - Discounted and UnDiscounted)
        public decimal? BdgtCapexAllowance { get; set; } // RESTORE_BdgtCapexAllowance - Deduct Budgeted Capex from Capitalised value
        public decimal? SinkingFundAllowance { get; set; } // RESTORE_SinkingFundAllowance - Deduct Sinking Fund from Capitalised value
        public string RefurbGrowthRate { get; set; } // RESTORE_RefurbGrowthRate - Refurbishment Growth Code - (I see dropdown in the workbook. Cell 89)
        public string ReversionDefault { get; set; } // RESTORE_ReversionDefault - Default Reversion calculation applied to Market Cap Approach - (I see dropdown in the workbook. Cell 92)
        public string StepReversions_AppliedRate { get; set; } // RESTORE_StepReversions_AppliedRate - Step Reversions - Apply Cap Rate or Discount Rate -(Enum - Cap Rate or Discount Rate)
        public string StepReversions_InflateMkt { get; set; } // RESTORE_StepReversions_InflateMkt - Step Reversions - Inflate Market Rent for Step Reversions -(Enum - Yes or No)
        public decimal? ExpiryAllowanceWindow_TV { get; set; } // RESTORE_ExpiryAllowanceWindow_TV - TERMINAL YEAR - Make Expiry Allowances for Tenancies expiring within
        public decimal? BdgtCapexAllowanceTerminal { get; set; } // RESTORE_BdgtCapexAllowanceTerminal - TERMINAL YEAR - Budgeted Capex Allowance
        public decimal? SinkingFundAllowanceTerminal { get; set; } // RESTORE_SinkingFundAllowanceTerminal - TERMINAL YEAR - Sinking Fund Allowance
        public decimal AcqCostsLegal { get; set; } // RESTORE_AcqCostsLegal -  Legal Fees
        public decimal AcqCostDD { get; set; } // RESTORE_AcqCostDD - Due Diligence
        public decimal? AcqCost_AgencyCommission { get; set; } // RESTORE_AcqCost_AgencyCommission - Agency Commission
        public decimal AcqCostsOther { get; set; } // RESTORE_AcqCostsOther - Other
        public decimal? ROUNDING_UB { get; set; }
        public decimal? ROUNDING { get; set; }
        public decimal? StampDuties { get; set; }

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
