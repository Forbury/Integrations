
using Forbury.Integrations.API.v1.Dto.Model.Retail.Input.Space.Lease;

namespace Forbury.Integrations.API.v1.Dto.Model.Retail.Input.Space
{
    public class RetailSpaceDto: Commercial.Input.Space.SpaceDto
    {
        /***
         * General Ledger code used to lookup on General Ledger list provided
         */
        public string GeneralLedgerCode { get; set; }

        public new RetailLeaseDto Lease { get; set; }
    }
}
