using System;
using Forbury.Integrations.Helpers.Converters;
using Newtonsoft.Json;

namespace Forbury.Integrations.API.v1.Dto.Input.Capex
{
    public class SinkingFundDto
    {
        public string Rate { get; set; }
        public string Amount { get; set; }
        public bool? Deduct { get; set; }
        [JsonConverter(typeof(DateFormatConverter), JsonFormats.DateFormat)]
        public DateTime? StartDate { get; set; }
        public string GrowthRateName { get; set; }
    }
}
