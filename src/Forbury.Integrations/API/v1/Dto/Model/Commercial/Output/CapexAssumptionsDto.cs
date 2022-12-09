namespace Forbury.Integrations.API.v1.Dto.Model.Commercial.Output
{
    public class CapexAssumptionsDto
    {
        public decimal TenYearCapex { get; set; }
        public decimal TenYearCapexPsqm { get; set; }
        public decimal TenYearCapexPresentValue { get; set; }
        public decimal TenYearCapexTerminalInclusive { get; set; }
        public decimal TenYearCapexTerminalInclusivePsqm { get; set; }
        public decimal TenYearCapexTerminalInclusivePresentValue { get; set; }
    }
}
