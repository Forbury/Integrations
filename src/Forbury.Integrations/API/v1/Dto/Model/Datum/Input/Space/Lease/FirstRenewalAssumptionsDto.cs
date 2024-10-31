using System;
using Forbury.Integrations.API.v1.Dto.Model.Datum.Input.Space.Lease.Options;
using Forbury.Integrations.Helpers.Converters;
using Newtonsoft.Json;

namespace Forbury.Integrations.API.v1.Dto.Model.Datum.Input.Space.Lease
{
    public class FirstRenewalAssumptionsDto
    {
        [JsonConverter(typeof(DateFormatConverter), JsonFormats.DateFormat)]  public DateTime? StartDate { get; set; }
        public decimal BaseRent { get; set; }
        public decimal MarketRent { get; set; }
        public DatumLeaseOptionsDto LeaseOptions { get; set; }
        public DatumLeaseVacancyOptionsDto VacancyOptions { get; set; }
        public DatumLeaseFeeOptionsDto FeeOptions { get; set; }
    }
}
