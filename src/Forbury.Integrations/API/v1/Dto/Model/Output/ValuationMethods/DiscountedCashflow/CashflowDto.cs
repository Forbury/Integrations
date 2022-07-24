using System.Collections.Generic;
using Forbury.Integrations.Helpers.Converters;
using Newtonsoft.Json;

namespace Forbury.Integrations.API.v1.Dto.Model.Output.ValuationMethods.DiscountedCashflow
{
    public class CashflowDto
    {
        public List<RenewalTypeRentDto> RenewalTypeBaseRents { get; set; }
        public decimal PercentageRent { get; set; }
        public decimal Recoveries { get; set; }

        public decimal SundryIncome { get; set; }
        public decimal SpecialIncome { get; set; }
        public decimal Stabilisation { get; set; }
        public decimal OtherAdjustments { get; set; }

        public decimal StatutoryExpenses { get; set; }
        public decimal OperatingExpenses { get; set; }
        public decimal GroundRent { get; set; }
        public decimal NonRecoverableExpenses { get; set; }

        public decimal VacancyAllowance { get; set; }

        public decimal Incentives { get; set; }
        public decimal LeasingCosts { get; set; }

        public decimal Refurbishment { get; set; }
        public decimal BudgetedCapex { get; set; }
        public decimal SinkingFund { get; set; }
    }
}