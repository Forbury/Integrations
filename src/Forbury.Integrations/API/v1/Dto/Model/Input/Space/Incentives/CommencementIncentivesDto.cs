namespace Forbury.Integrations.API.v1.Dto.Model.Input.Space.Incentives
{
    public class CommencementIncentivesDto
    {
        public decimal? CommencementBaseRent { get; set; }
        public decimal? CommencementRecoveries { get; set; }
        public decimal? Total { get; set; }
        public string Type { get; set; }
        public IncentiveAmortisationDto IncentiveAmortisation { get; set; }
    }
}