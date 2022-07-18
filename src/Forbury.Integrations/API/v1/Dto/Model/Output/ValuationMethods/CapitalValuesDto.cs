namespace Forbury.Integrations.API.v1.Dto.Model.Output.ValuationMethods
{
    public class CapitalValuesDto
    {
        public decimal RentalReversions { get; set; }
        public decimal SpecialIncome { get; set; }
        public decimal Stabilisation { get; set; }
        public decimal OtherAdjustments { get; set; }
        public decimal OutstandingIncentives { get; set; }
        public decimal AdditionalLand { get; set; }

        public AllowancesDto DeferredTenancies { get; set; }
        public AllowancesDto ExistingVacancies { get; set; }
        public AllowancesDto ImminentExpiries { get; set; }

        public decimal BudgetedCapex { get; set; }
        public decimal SinkingFund { get; set; }
    }
}
