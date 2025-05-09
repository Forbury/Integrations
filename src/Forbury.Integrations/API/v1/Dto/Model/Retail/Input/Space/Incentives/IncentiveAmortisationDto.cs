using System;
using Forbury.Integrations.Helpers.Converters;
using Newtonsoft.Json;

namespace Forbury.Integrations.API.v1.Dto.Model.Retail.Input.Space.Incentives
{
    public class IncentiveAmortisationDto
    {
        public decimal? PaidToDate { get; set; }
        [JsonConverter(typeof(DateFormatConverter), JsonFormats.DateFormat)]
        public DateTime? StartDate { get; set; }
    }
}