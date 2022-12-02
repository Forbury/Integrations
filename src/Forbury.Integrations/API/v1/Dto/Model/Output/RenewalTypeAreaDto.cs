namespace Forbury.Integrations.API.v1.Dto.Model.Output
{
    public class RenewalTypeAreaDto : RenewalTypeDto
    {
        public decimal Area { get; set; }
        public int TenantsCount { get; set; }
    }
}