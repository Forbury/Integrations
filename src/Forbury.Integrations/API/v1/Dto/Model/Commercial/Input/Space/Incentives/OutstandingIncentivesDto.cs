namespace Forbury.Integrations.API.v1.Dto.Model.Commercial.Input.Space.Incentives
{
    public class OutstandingIncentivesDto
    {
        public LumpSumIncentivesDto LumpSumIncentives { get; set; }
        public RebateIncentivesDto RebateIncentives { get; set; }
        public RentFreeIncentivesDto RentFreeIncentives { get; set; }
    }
}