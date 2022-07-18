using System.Collections.Generic;

namespace Forbury.Integrations.API.v1.Dto.Property
{
    public class PropertyDetailedDto : PropertyDto
    {
        public List<int> ModelIds { get; set; }
        public List<int> TeamIds { get; set; }
    }
}
