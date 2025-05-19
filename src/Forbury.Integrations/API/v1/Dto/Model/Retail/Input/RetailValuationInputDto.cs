using System.Collections.Generic;
using Forbury.Integrations.API.v1.Dto.Model.Commercial.Input;
using Forbury.Integrations.API.v1.Dto.Model.Retail.Input.Future;
using Forbury.Integrations.API.v1.Dto.Model.Retail.Input.General;
using Forbury.Integrations.API.v1.Dto.Model.Retail.Input.GeneralLedger;
using Forbury.Integrations.API.v1.Dto.Model.Retail.Input.Space;

namespace Forbury.Integrations.API.v1.Dto.Model.Retail.Input
{
    public class RetailValuationInputDto : ValuationInputDto
    {
        public new RetailGeneralDto General { get; set; }
        public new List<RetailSpaceDto> Spaces { get; set; }
        public new RetailFuturesDto Futures { get; set; }

        public List<GeneralLedgerDto> GeneralLedgers { get; set; }
    }
}
