namespace Forbury.Integrations.API.v1.Dto.Model.Commercial.Input.Outgoings
{
    public class RecoveryProfileDto
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal? AdoptedArea { get; set; }
        public decimal? FirstAdjustmentAmount { get; set; }
        public decimal? SecondAdjustmentAmount { get; set; }
    }
}