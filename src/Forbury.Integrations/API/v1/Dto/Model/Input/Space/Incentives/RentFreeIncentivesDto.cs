using System;
using Forbury.Integrations.API.v1.Dto.Model.Input.Enums;
using Forbury.Integrations.Helpers.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Forbury.Integrations.API.v1.Dto.Model.Input.Space.Incentives
{
    public class RentFreeIncentivesDto
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public RentFreeBasisType Basis { get; set; }
        public decimal? PercentApplied { get; set; }
        [JsonConverter(typeof(DateFormatConverter), JsonFormats.DateFormat)]
        public DateTime? StartDate { get; set; }
        [JsonConverter(typeof(DateFormatConverter), JsonFormats.DateFormat)]
        public DateTime? EndDate { get; set; }
    }
}