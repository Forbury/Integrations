using System;
using System.Collections.Generic;
using Forbury.Integrations.Helpers.Converters;
using Newtonsoft.Json;

namespace Forbury.Integrations.API.v1.Dto.Model.Commercial.Output.ValuationMethods
{
    public class BaseValuationDto
    {
        [JsonConverter(typeof(DateFormatConverter), JsonFormats.DateFormat)] public DateTime ExpiryAllowanceDate { get; set; }
        public decimal ExpiryAllowanceNetLettableAreaPercent { get; set; }

        public List<RenewalTypeIncomeDto> RenewalTypeGrossMarketIncomes { get; set; }
        public decimal SundryIncomePA { get; set; }

        public CapitalValuesDto CapitalValues { get; set; }

        public OutgoingsOutputsDto Outgoings { get; set; }
        public decimal VacancyAllowancePA { get; set; }

        public decimal NetMarketIncomePA { get; set; }

        public decimal CapitalisedAdjustments { get; set; }
        [JsonConverter(typeof(DecimalRoundingConverter), 6)] public decimal CapitalisationRate { get; set; }
        public decimal CapitalisedCoreValue { get; set; }

        public decimal CapitalisedValue { get; set; }
    }
}