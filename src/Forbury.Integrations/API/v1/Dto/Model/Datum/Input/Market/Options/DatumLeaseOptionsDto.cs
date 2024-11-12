namespace Forbury.Integrations.API.v1.Dto.Model.Datum.Input.Market.Options
{
    public class DatumLeaseOptionsDto
    {
        public int? TermYears { get; set; }
        public string ReviewType { get; set; }
        public int? ReviewFrequencyYears { get; set; }
        public int? RentFreeMonths { get; set; }
    }
}
