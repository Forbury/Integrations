using System.Collections.Generic;
using Forbury.Integrations.API.v1.Dto.Input.Capex;
using Forbury.Integrations.API.v1.Dto.Input.Future;
using Forbury.Integrations.API.v1.Dto.Input.General;
using Forbury.Integrations.API.v1.Dto.Input.Outgoings;
using Forbury.Integrations.API.v1.Dto.Input.Reporting;
using Forbury.Integrations.API.v1.Dto.Input.Space;

namespace Forbury.Integrations.API.v1.Dto.Input
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
