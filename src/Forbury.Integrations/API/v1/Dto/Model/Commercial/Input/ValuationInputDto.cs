using System.Collections.Generic;
using Forbury.Integrations.API.v1.Dto.Model.Commercial.Input.Capex;
using Forbury.Integrations.API.v1.Dto.Model.Commercial.Input.Future;
using Forbury.Integrations.API.v1.Dto.Model.Commercial.Input.General;
using Forbury.Integrations.API.v1.Dto.Model.Commercial.Input.Outgoings;
using Forbury.Integrations.API.v1.Dto.Model.Commercial.Input.Reporting;
using Forbury.Integrations.API.v1.Dto.Model.Commercial.Input.Space;

namespace Forbury.Integrations.API.v1.Dto.Model.Commercial.Input
{
    public class ValuationInputDto : IModelInput
    {
        public GeneralDto General { get; set; }
        public List<SpaceDto> Spaces { get; set; }
        public ReportingDto Reporting { get; set; }
        public CapexDto Capex { get; set; }
        public OutgoingsDto Outgoings { get; set; }
        public FuturesDto Futures { get; set; }
    }
}
