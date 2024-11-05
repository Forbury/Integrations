using Forbury.Integrations.API.v1.Dto.Model.Datum.Input.Space.Lease.Options;

namespace Forbury.Integrations.API.v1.Dto.Model.Datum.Input.Space.Lease
{
    public class DatumMarketLeasingAssumptionsDto
    {
        public string Description { get; set; }
        public DatumLeaseOptionsDto LeaseOptions { get; set; }
        public DatumLeaseVacancyOptionsDto VacancyOptions { get; set; }
        public DatumLeaseFeeOptionsDto FeeOptions { get; set; }
    }
}
