namespace Forbury.Integrations.API.v1.Dto.Model.Commercial.Output
{
    public class IncomeAnalysisDto
    {
        public decimal GrossPassingIncomePA { get; set; }
        public decimal GrossPassingIncomePsqm { get; set; }
        public decimal GrossMarketIncomePA { get; set; }
        public decimal GrossMarketIncomePsqm { get; set; }
        public decimal NetPassingIncomePA { get; set; }
        public decimal NetPassingIncomePsqm { get; set; }
        public decimal NetMarketIncomePA { get; set; }
        public decimal NetMarketIncomePsqm { get; set; }
        public decimal NetPassingIncomeFullyLeasedPA { get; set; }
        public decimal OutgoingsPA { get; set; }
        public decimal OutgoingsPsqm { get; set; }
        public decimal SpecialIncome { get; set; }
        public decimal CarparkingGrossIncomePassingPA { get; set; }
    }
}