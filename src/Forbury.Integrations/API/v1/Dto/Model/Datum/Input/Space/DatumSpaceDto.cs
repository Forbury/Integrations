using Forbury.Integrations.API.v1.Dto.Model.Datum.Input.Space.Lease;

namespace Forbury.Integrations.API.v1.Dto.Model.Datum.Input.Space
{
    public class DatumSpaceDto
    {
        public DatumLeaseDto Lease { get; set; }

        public string ExternalId { get; set; }
        public string Demise { get; set; }
        public decimal? MarketRent { get; set; }
        public decimal? LettableArea { get; set; }

        public string MarketLeasingAssumptionProfile { get; set; }
        public DatumFirstRenewalAssumptionsDto DatumFirstRenewalOverrides { get; set; }
    }
}
