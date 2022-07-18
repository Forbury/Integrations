using Forbury.Integrations.Helpers.Converters;
using Newtonsoft.Json;
using System;

namespace Forbury.Integrations.API.v1.Dto.Model.Input.Space.Incentives
{
    public class LumpSumIncentivesDto
    {
        public decimal? Amount { get; set; }
        [JsonConverter(typeof(DateFormatConverter), JsonFormats.DateFormat)]
        public DateTime? PaymentDate { get; set; }
    }
}