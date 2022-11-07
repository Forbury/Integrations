using System.Collections.Generic;
using Forbury.Integrations.API.v1.Dto.Model.Datum.Input;

namespace Forbury.Integrations.API.v1.Dto.Model.Datum
{
    public class ModelDatumDetailedDto : ModelDto
    {
        public ModelDatumInputDto Inputs { get; set; }
        public Dictionary<string, dynamic> CustomFields { get; set; }
    }
}