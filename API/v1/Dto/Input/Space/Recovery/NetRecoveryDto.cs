namespace Forbury.Integrations.API.v1.Dto.Input.Space.Recovery
{
    public class NetRecoveryDto : RecoveryDto
    {
        public string RecoveryCode { get; set; }
        public decimal? AmountPerAnnum { get; set; }
    }
}