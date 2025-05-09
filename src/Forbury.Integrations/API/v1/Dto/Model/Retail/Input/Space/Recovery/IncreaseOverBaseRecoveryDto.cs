namespace Forbury.Integrations.API.v1.Dto.Model.Retail.Input.Space.Recovery
{
    public class IncreaseOverBaseRecoveryDto : RecoveryDto
    {
        public string RecoveryCode { get; set; }
        public string ReviewThreshold { get; set; }
        public decimal? BaseAmount { get; set; }
        public decimal? PercentageApplied { get; set; }
        public decimal? Cap { get; set; }
        public decimal? Collar { get; set; }
    }
}