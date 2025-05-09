using System;
using Forbury.Integrations.Helpers.Converters;
using Newtonsoft.Json;

namespace Forbury.Integrations.API.v1.Dto.Model.Retail.Input.Space.Review
{
    public class RentReviewDto
    {
        [JsonConverter(typeof(DateFormatConverter), JsonFormats.DateFormat)]
        public DateTime? Date { get; set; }
        public string Type { get; set; }
        public decimal? Cap { get; set; }
        public decimal? Collar { get; set; }
        public decimal? Threshold { get; set; }
    }
}
