using Forbury.Integrations.API.v1.Dto.Model.Commercial.Input.Future;
using System.Collections.Generic;

namespace Forbury.Integrations.API.v1.Dto.Model.Retail.Input.Future
{
    public class RetailFuturesDto: FuturesDto
    {
        public new List<RetailRenewalAssumptionDto> RenewalAssumptions { get; set; }
    }
}
