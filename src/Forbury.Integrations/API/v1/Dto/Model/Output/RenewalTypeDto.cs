using Forbury.Integrations.API.v1.Dto.Enums;

namespace Forbury.Integrations.API.v1.Dto.Model.Output
{
    public abstract class RenewalTypeDto
    {
        public RenewalTypeRankType Rank { get; set; }
        public string Name { get; set; }
    }
}
