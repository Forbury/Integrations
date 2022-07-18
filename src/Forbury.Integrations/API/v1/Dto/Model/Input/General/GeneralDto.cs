using System;
using Forbury.Integrations.API.v1.Dto.Enums;
using Forbury.Integrations.Helpers.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Forbury.Integrations.API.v1.Dto.Model.Input.General
{
    public class GeneralDto
    {
        [JsonConverter(typeof(DateFormatConverter), JsonFormats.DateFormat)]
        public DateTime? ValuationDate { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public ValuationType ValuationType { get; set; }
        public decimal? RoundedAdoptedValue { get; set; }
        public decimal? AdoptedValueAdjustment { get; set; }
        public decimal? CapRateInitial { get; set; }
        public decimal? CapRateMarket { get; set; }
        public decimal? CapRateTerminalBps { get; set; }
        public decimal? InterestValued { get; set; }
        public string IncentiveBasis { get; set; }
        public decimal? ExpiryAllowanceMonths { get; set; }
        public decimal? DiscountRate { get; set; }
        public decimal? CapRateTerminal { get; set; }
    }
}
