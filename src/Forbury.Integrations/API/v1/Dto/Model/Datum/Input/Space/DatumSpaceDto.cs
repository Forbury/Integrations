using Forbury.Integrations.API.v1.Dto.Model.Datum.Input.Space.Lease;

namespace Forbury.Integrations.API.v1.Dto.Model.Datum.Input.Space
{
    public class DatumSpaceDto
    {
        public DatumLeaseDto Lease { get; set; }

        public decimal? MarketRent { get; set; }
        public decimal? LettableArea { get; set; }
    }
}
