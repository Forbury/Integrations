namespace Forbury.Integrations.API.v1.Dto.Output.ValuationMethods
{
    public class AllowancesDto
    {
        public decimal Incentives { get; set; }
        public decimal LeasingCosts { get; set; }
        public decimal LettingUp { get; set; }
        public decimal? Refurbishment { get; set; }
    }
}