using System;
using Forbury.Integrations.Helpers.Converters;
using Newtonsoft.Json;

namespace Forbury.Integrations.API.v1.Dto.Model.Datum.Input.Space.Lease
{
    public class DatumReviewDto
    {
        public string Type { get; set; }
        [JsonConverter(typeof(DateFormatConverter), JsonFormats.DateFormat)] public DateTime Date { get; set; }
        public string Cap { get; set; }
        public string Collar { get; set; }
    }
}
