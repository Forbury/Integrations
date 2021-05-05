using System.Collections.Generic;

namespace Forbury.Integrations.API.v1.Dto.Input.Future
{
    public class GrowthAssumptionDto
    {
        public string Name { get; set; }
        public decimal? IncreaseOnCpi { get; set; }
        public List<decimal?> Rates { get; set; }
    }
}
