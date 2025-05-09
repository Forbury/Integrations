using System;
using Forbury.Integrations.Helpers.Converters;
using Newtonsoft.Json;

namespace Forbury.Integrations.API.v1.Dto.Model.Retail.Input.Space.Incentives
{
    public class LumpSumIncentivesDto
    {
        public decimal? Amount { get; set; }
        [JsonConverter(typeof(DateFormatConverter), JsonFormats.DateFormat)]
        public DateTime? PaymentDate { get; set; }
    }
}