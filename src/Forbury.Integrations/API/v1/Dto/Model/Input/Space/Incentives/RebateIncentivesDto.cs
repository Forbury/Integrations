using Forbury.Integrations.Helpers.Converters;
using Newtonsoft.Json;
using System;

namespace Forbury.Integrations.API.v1.Dto.Model.Input.Space.Incentives
{
    public class RebateIncentivesDto
    {
        public decimal? AmountMonthly { get; set; }
        [JsonConverter(typeof(DateFormatConverter), JsonFormats.DateFormat)]
        public DateTime? StartDate { get; set; }
        [JsonConverter(typeof(DateFormatConverter), JsonFormats.DateFormat)]
        public DateTime? EndDate { get; set; }
    }
}