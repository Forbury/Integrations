using Forbury.Integrations.API.v1.Dto.Input;
using Forbury.Integrations.API.v1.Dto.Output;

namespace Forbury.Integrations.API.v1.Dto
{
    public class ModelDto
    {
        public ModelAttributesDto Attributes { get; set; }
        public PropertyDto Property { get; set; }
        public ValuationInputDto Inputs { get; set; }
        public ValuationOutputDto Outputs { get; set; }
    }
}
