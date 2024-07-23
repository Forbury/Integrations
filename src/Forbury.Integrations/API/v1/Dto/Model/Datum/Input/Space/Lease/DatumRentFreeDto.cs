using System;
using Forbury.Integrations.Helpers.Converters;
using Newtonsoft.Json;

namespace Forbury.Integrations.API.v1.Dto.Model.Datum.Input.Space.Lease
{
    public class DatumRentFreeDto
    {
        [JsonConverter(typeof(DateFormatConverter), JsonFormats.DateFormat)] public DateTime? Date { get; set; }
        public decimal Months { get; set; }
        public decimal Percent { get; set; }
    }
}