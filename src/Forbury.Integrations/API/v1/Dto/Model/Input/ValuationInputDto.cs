using System.Collections.Generic;
using Forbury.Integrations.API.v1.Dto.Model.Input.Capex;
using Forbury.Integrations.API.v1.Dto.Model.Input.Future;
using Forbury.Integrations.API.v1.Dto.Model.Input.General;
using Forbury.Integrations.API.v1.Dto.Model.Input.Outgoings;
using Forbury.Integrations.API.v1.Dto.Model.Input.Reporting;
using Forbury.Integrations.API.v1.Dto.Model.Input.Space;

namespace Forbury.Integrations.API.v1.Dto.Model.Input
{
    public class ValuationInputDto
    {
        public GeneralDto General { get; set; }
        public List<SpaceDto> Spaces { get; set; }
        public ReportingDto Reporting { get; set; }
        public CapexDto Capex { get; set; }
        public OutgoingsDto Outgoings { get; set; }
        public FuturesDto Futures { get; set; }
    }
}
