namespace Forbury.Integrations.API.v1.Dto.Model.Datum.Input.Space.Lease.Options
{
    public class DatumLeaseVacancyOptionsDto
    {
        public int? DowntimeMonths { get; set; }
        public int? PreRefurbMonths { get; set; }
        public int? RefurbMonths { get; set; }
        public decimal? RefurbAmount { get; set; }
    }
}
