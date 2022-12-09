namespace Forbury.Integrations.API.v1.Dto.Model.Commercial.Output.ValuationMethods.DiscountedCashflow
{
    public class TerminalValuationDto : BaseValuationDto
    {
        public decimal DisposalCosts { get; set; }
        public decimal NetSaleProceeds { get; set; }
    }
}