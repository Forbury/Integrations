using System.Collections.Generic;

namespace Forbury.Integrations.API.v1.Dto.Model
{
    public abstract class ModelDetailedDto<TInput, TOutput> : ModelDto
        where TInput : IModelInput
        where TOutput : IModelOutput
    {
        public TInput Inputs { get; set; }
        public TOutput Outputs { get; set; }
        public Dictionary<string, dynamic> CustomFields { get; set; }
    }

    public interface IModelInput { }

    public interface IModelOutput { }
}
