using Forbury.Integrations.API.v1.Dto.Enums;
using Forbury.Integrations.API.v1.Dto.Model.Commercial.Input.General.Incentives;
using Forbury.Integrations.Helpers.Converters;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

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

        // Don't move these even though they belong to Capitialisation
        public decimal? BudgetedCapexAllowanceMonths { get; set; }
        public decimal? SinkingFundAllowanceMonths { get; set; }

        [JsonConverter(typeof(DateFormatConverter), JsonFormats.DateFormat)]
        [DisplayName("Leasehold Expiry")]
        public DateTime? LeaseholdExpiryDate { get; set; } //RESTORE_LHexpiry - Date of Lease Expiry
        public HistoricalCpiSource HistoricalCpiSource { get; set; } // RESTORE_CPI_source - Historical CPI Source

        // remove this class
        //public FutureIncentivesDto? FutureIncentives { get; set; }

        // Move these into FuturesDto
        // Name as IncentiveLumpSum 
        //public decimal? General_FutureIncentiveLumpSum { get; set; } //RESTORE_General_FutureIncentiveLumpSum - Default Proportion of Future Incentives treated as lump sum
        // Name as IncentiveRentFree
        //public decimal? General_FutureIncentivesRentFree { get; set; } //Restore_FutureIncentivesRentFree - Default Proportion of Future Incentives treated as rent free

        // ORIGINAL JINS
        //public string Basis_LeasingCosts { get; set; } //RESTORE_Basis_LeasingCosts - Input rent basis for % lease cost calculations - (Enum - Net and Gross)
        //public decimal? RevFreqDefault { get; set; } //RESTORE_RevFreqDefault - Default Review Frequency
        //public string LumSumAppliedRate { get; set; } //RESTORE_LumSumAppliedRate - Lump Sum Payments - Apply Cap Rate or Discount Rate -(Enum - Cap Rate or Discount Rate)
        //public string RebateAppliedRate { get; set; } //RESTORE_RebateAppliedRate - Rebates - Apply Cap Rate or Discount Rate -(Enum - Cap Rate or Discount Rate)
        //public string RentFreeAppliedRate { get; set; } //RESTORE_RentFreeAppliedRate - Rent Free Periods - Apply Cap Rate or Discount Rate -(Enum - Cap Rate or Discount Rate)
        //public string ExistingVacancyRate { get; set; } //RESTORE_ExistingVacancyRate - Discount rate applied to existing vacancy allowances -(Enum - None, Cap Rate or Discount Rate)
        //public decimal? ExpiryAllowanceWindow_CAP { get; set; } // RESTORE_ExpiryAllowanceWindow_CAP - CAP VALUATION - Make expiry allowances for tenancies expiring within - (Any integer between 0 to 60)
        //public string ExpiryAllowanceWindow_Discount { get; set; } // RESTORE_ExpiryAllowanceWindow_Discount - Discounted expiries falling within first 12 months - (Enum - Discounted and UnDiscounted)
        //public decimal? BdgtCapexAllowance { get; set; } // RESTORE_BdgtCapexAllowance - Deduct Budgeted Capex from Capitalised value
        //public decimal? SinkingFundAllowance { get; set; } // RESTORE_SinkingFundAllowance - Deduct Sinking Fund from Capitalised value
        //public string RefurbGrowthRate { get; set; } // RESTORE_RefurbGrowthRate - Refurbishment Growth Code - (I see dropdown in the workbook. Cell 89)
        //public string ReversionDefault { get; set; } // RESTORE_ReversionDefault - Default Reversion calculation applied to Market Cap Approach - (I see dropdown in the workbook. Cell 92)
        //public string StepReversions_AppliedRate { get; set; } // RESTORE_StepReversions_AppliedRate - Step Reversions - Apply Cap Rate or Discount Rate -(Enum - Cap Rate or Discount Rate)
        //public string StepReversions_InflateMkt { get; set; } // RESTORE_StepReversions_InflateMkt - Step Reversions - Inflate Market Rent for Step Reversions -(Enum - Yes or No)
        //public decimal? ExpiryAllowanceWindow_TV { get; set; } // RESTORE_ExpiryAllowanceWindow_TV - TERMINAL YEAR - Make Expiry Allowances for Tenancies expiring within
        //public decimal? BdgtCapexAllowanceTerminal { get; set; } // RESTORE_BdgtCapexAllowanceTerminal - TERMINAL YEAR - Budgeted Capex Allowance
        //public decimal? SinkingFundAllowanceTerminal { get; set; } // RESTORE_SinkingFundAllowanceTerminal - TERMINAL YEAR - Sinking Fund Allowanc
        //public decimal AcqCostsLegal { get; set; } // RESTORE_AcqCostsLegal -  Legal Fees
        //public decimal AcqCostDD { get; set; } // RESTORE_AcqCostDD - Due Diligence
        //public decimal? AcqCost_AgencyCommission { get; set; } // RESTORE_AcqCost_AgencyCommission - Agency Commission
        //public decimal AcqCostsOther { get; set; } // RESTORE_AcqCostsOther - Other
        //public decimal? UpperBound { get; set; }
        //public decimal? Rounding { get; set; }
        //public decimal? StampDuties { get; set; }

        public string LeasingCostsBasis { get; set; } //RESTORE_Basis_LeasingCosts - Input rent basis for % lease cost calculations - (Enum - Net and Gross)

        // validate: between 1 to 5 only
        public decimal? DefaultReviewFrequency { get; set; } //RESTORE_RevFreqDefault - Default Review Frequency 

        // enum CapRate / DiscountRate 
        public string LumpSumAppliedRateType { get; set; } //RESTORE_LumSumAppliedRate - Lump Sum Payments - Apply Cap Rate or Discount Rate -(Enum - Cap Rate or Discount Rate)
        // enum CapRate / DiscountRate 
        public string RebateAppliedRateType { get; set; } //RESTORE_RebateAppliedRate - Rebates - Apply Cap Rate or Discount Rate -(Enum - Cap Rate or Discount Rate)
        // enum CapRate / DiscountRate 
        public string RentFreeAppliedRateType { get; set; } //RESTORE_RentFreeAppliedRate - Rent Free Periods - Apply Cap Rate or Discount Rate -(Enum - Cap Rate or Discount Rate)

        // enum None / CapRate / DiscountRate
        public string ExistingVacancyRateType { get; set; } //RESTORE_ExistingVacancyRate - Discount rate applied to existing vacancy allowances -(Enum - None, Cap Rate or Discount Rate)

        // existed
        //public decimal? ExpiryAllowanceMonths { get; set; } // RESTORE_ExpiryAllowanceWindow_CAP - CAP VALUATION - Make expiry allowances for tenancies expiring within - (Any integer between 0 to 60)

        // enum Undiscounted / Discounted
        public string ExpiryAllowanceDiscountType { get; set; } // RESTORE_ExpiryAllowanceWindow_Discount - Discounted expiries falling within first 12 months - (Enum - Discounted and UnDiscounted)


        // Capitialisation section - create new class under Input > General > called CapitalisationDto

        // existed BudgetedCapexAllowanceMonths
        public decimal? BdgtCapexAllowance { get; set; } // RESTORE_BdgtCapexAllowance - Deduct Budgeted Capex from Capitalised value

        // existed SinkingFundAllowanceMonths
        public decimal? SinkingFundAllowance { get; set; } // RESTORE_SinkingFundAllowance - Deduct Sinking Fund from Capitalised value

        // coming from RESTORE.TB_Future_InflationAssumptionNames (Or GrowthAssumptions.Name in Futures***)
        public string RefurbGrowthRate { get; set; } // RESTORE_RefurbGrowthRate - Refurbishment Growth Code - (I see dropdown in the workbook. Cell 89)

        // enum Step or Static
        public string DefaultReversionType { get; set; } // RESTORE_ReversionDefault - Default Reversion calculation applied to Market Cap Approach - (I see dropdown in the workbook. Cell 92)

        // enum CapRate / DiscountRate
        public string StepReversionsAppliedRateType { get; set; } // RESTORE_StepReversions_AppliedRate - Step Reversions - Apply Cap Rate or Discount Rate -(Enum - Cap Rate or Discount Rate)

        // boolean
        public string StepReversionInflateMarketRent { get; set; } // RESTORE_StepReversions_InflateMkt - Step Reversions - Inflate Market Rent for Step Reversions -(Enum - Yes or No)

        // End of Capitialisation

        // DCF Section - create new class under Input > General > called DiscountedCashflowDto

        // validate: between 0 to 60 only, existed as TerminalExpiryAllowanceMonths
        //public decimal? ExpiryAllowanceTerminal { get; set; } // RESTORE_ExpiryAllowanceWindow_TV - TERMINAL YEAR - Make Expiry Allowances for Tenancies expiring within

        // validate: between 0 to 60 only
        public decimal? TerminalBudgetedCapexAllowanceMonths { get; set; } // RESTORE_BdgtCapexAllowanceTerminal - TERMINAL YEAR - Budgeted Capex Allowance

        // validate: between 0 to 60 only
        public decimal? TerminalSinkingFundAllowanceMonths { get; set; } // RESTORE_SinkingFundAllowanceTerminal - TERMINAL YEAR - Sinking Fund Allowanc
        
        // End of DCF section

        // TO BE GROUPED into AcquisitionCosts: AcquisitionCostDto 
        public decimal AcqCostsLegal { get; set; } // RESTORE_AcqCostsLegal -  Legal Fees
        public decimal AcqCostDD { get; set; } // RESTORE_AcqCostDD - DueDiligence
        public decimal? AcqCost_AgencyCommission { get; set; } // RESTORE_AcqCost_AgencyCommission - AgencyCommission
        public decimal AcqCostsOther { get; set; } // RESTORE_AcqCostsOther - Other

        // change these three to List<<decimal?>  option 1: { 100,000, null, 1000000, null, 1000000 } [the value will skip when it;s null OR option 2: { 100,000, 0, 1000000, 0, 1000000 } [the value will be 0]
        public decimal? UpperBound { get; set; }
        public decimal? Rounding { get; set; }
        public decimal? StampDuties { get; set; }

        // TO DO, how we can leverage data annotation to give a proper name on each validation
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
