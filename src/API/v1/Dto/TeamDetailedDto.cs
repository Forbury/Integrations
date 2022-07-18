using System.Collections.Generic;

namespace Forbury.Integrations.API.v1.Dto
{
    public class TeamDetailedDto : TeamDto
    {
        public int CommercialModelsCount { get; set; }

        public List<int> ModelIds { get; set; }
        public List<int> PropertyIds { get; set; }
    }
}
