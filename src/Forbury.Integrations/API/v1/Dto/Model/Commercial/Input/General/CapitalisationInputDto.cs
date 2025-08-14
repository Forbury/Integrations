using Forbury.Integrations.API.v1.Dto.Model.Commercial.Input.Enums;

namespace Forbury.Integrations.API.v1.Dto.Model.Commercial.Input.General
{   
    public class CapitalisationInputDto
    {
        public string RefurbGrowthRate { get; set; }

        public ReversionType DefaultReversionType { get; set; }

        public RateType StepReversionsAppliedRateType { get; set; }

        public bool? StepReversionInflateMarketRent { get; set; }
    }
}
