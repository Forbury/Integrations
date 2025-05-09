using System.Collections.Generic;
using Forbury.Integrations.API.v1.Dto.Model.Interfaces;
using Forbury.Integrations.API.v1.Dto.Model.Retail.Input.Capex;
using Forbury.Integrations.API.v1.Dto.Model.Retail.Input.Future;
using Forbury.Integrations.API.v1.Dto.Model.Retail.Input.General;
using Forbury.Integrations.API.v1.Dto.Model.Retail.Input.GeneralLedger;
using Forbury.Integrations.API.v1.Dto.Model.Retail.Input.Outgoings;
using Forbury.Integrations.API.v1.Dto.Model.Retail.Input.Reporting;
using Forbury.Integrations.API.v1.Dto.Model.Retail.Input.Space;

namespace Forbury.Integrations.API.v1.Dto.Model.Retail.Input
{
    public class ValuationInputDto : IModelInput
    {
        public GeneralDto General { get; set; }
        public List<SpaceDto> Spaces { get; set; }
        public ReportingDto Reporting { get; set; }
        public CapexDto Capex { get; set; }
        public OutgoingsDto Outgoings { get; set; }
        public FuturesDto Futures { get; set; }

        public List<GeneralLedgerDto> GeneralLedgers { get; set; }
    }
}
