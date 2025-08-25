namespace Forbury.Integrations.API.v1.Dto.Model.Commercial.Input.General
{   
    public class CapitalisationDto
    {
        public string RefurbGrowthRate { get; set; }

        public string DefaultReversionType { get; set; }

        public string StepReversionsAppliedRateType { get; set; }

        public bool? StepReversionInflateMarketRent { get; set; }
    }
}
