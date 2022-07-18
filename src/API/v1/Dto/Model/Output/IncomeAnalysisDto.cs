namespace Forbury.Integrations.API.v1.Dto.Model.Output
{
    public class IncomeAnalysisDto
    {
        public decimal GrossPassingIncomePA { get; set; }
        public decimal GrossMarketIncomePA { get; set; }
        public decimal NetPassingIncomePA { get; set; }
        public decimal NetPassingIncomeFullyLeasedPA { get; set; }
        public decimal NetMarketIncomePA { get; set; }
        public decimal OutgoingsPA { get; set; }
        public decimal SpecialIncome { get; set; }
        public decimal CarparkingGrossIncomePassingPA { get; set; }
    }
}