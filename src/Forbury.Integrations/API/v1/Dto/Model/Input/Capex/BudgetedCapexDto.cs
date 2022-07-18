using System;
using System.Collections.Generic;
using Forbury.Integrations.API.v1.Dto.Model.Input.Enums;
using Forbury.Integrations.Helpers.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Forbury.Integrations.API.v1.Dto.Model.Input.Capex
{
    public class BudgetedCapexDto
    {
        public string Name { get; set; }
        public string Category { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public BudgetedCapexType Type { get; set; }
        public string GrowthRateName { get; set; }
        /// <summary>
        /// Amounts are based of Type (annual or monthly).
        /// </summary>
        public List<decimal?> Amounts { get; set; }
        [JsonConverter(typeof(DateFormatConverter), JsonFormats.DateFormat)]
        public DateTime? StartDate { get; set; }
        public int? Months { get; set; }
        public decimal? TotalAmount { get; set; }
    }
}
