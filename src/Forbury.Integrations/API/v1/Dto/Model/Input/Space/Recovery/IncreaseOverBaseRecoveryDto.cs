using Forbury.Integrations.API.v1.Dto.Model.Input.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Forbury.Integrations.API.v1.Dto.Model.Input.Space.Recovery
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