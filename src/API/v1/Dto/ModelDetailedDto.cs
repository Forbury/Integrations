using Forbury.Integrations.API.v1.Dto.Input;
using Forbury.Integrations.API.v1.Dto.Output;
using System.Collections.Generic;

namespace Forbury.Integrations.API.v1.Dto
{
    public class ModelDetailedDto : ModelDto
    {
        public ValuationInputDto Inputs { get; set; }
        public ValuationOutputDto Outputs { get; set; }
        public Dictionary<string, dynamic> CustomFields { get; set; }
    }
}
