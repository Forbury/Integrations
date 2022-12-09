using Forbury.Integrations.Helpers.Converters;
using System;
using Newtonsoft.Json;

namespace Forbury.Integrations.API.v1.Dto.Model.Datum.Input.Space.Lease
{
    public class DatumLeaseDto
    {
        public string Name { get; set; }
        [JsonConverter(typeof(DateFormatConverter), JsonFormats.DateFormat)] public DateTime? StartDate { get; set; }
        [JsonConverter(typeof(DateFormatConverter), JsonFormats.DateFormat)] public DateTime? ExpiryDate { get; set; }
        public decimal? BaseRent { get; set; }
        [JsonConverter(typeof(DateFormatConverter), JsonFormats.DateFormat)] public DateTime? BreakDate { get; set; }
        public bool? IsBreakActive { get; set; }
    }
}
