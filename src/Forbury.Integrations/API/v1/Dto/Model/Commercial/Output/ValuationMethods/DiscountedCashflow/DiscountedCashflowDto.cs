using Forbury.Integrations.Helpers.Converters;
using Newtonsoft.Json;

namespace Forbury.Integrations.API.v1.Dto.Model.Commercial.Output.ValuationMethods.DiscountedCashflow
{
    public class DiscountedCashflowDto
    {
        [JsonConverter(typeof(DecimalRoundingConverter), 6)] public decimal DiscountRate { get; set; }

        public decimal SinkingFundHorizon { get; set; }
        [JsonConverter(typeof(DecimalRoundingConverter), 4)] public decimal WALEByArea { get; set; }
        [JsonConverter(typeof(DecimalRoundingConverter), 4)] public decimal WALEByRent { get; set; }
        [JsonConverter(typeof(DecimalRoundingConverter), 6)] public decimal AcquisitionCostsPercent { get; set; }
        [JsonConverter(typeof(DecimalRoundingConverter), 6)] public decimal DisposalCostsPercent { get; set; }

        public decimal SumDiscountedCashflows { get; set; }
        [JsonConverter(typeof(DecimalRoundingConverter), 6)] public decimal SumDiscountedCashflowsPercent { get; set; }
        public decimal TerminalValuePresentValue { get; set; }
        [JsonConverter(typeof(DecimalRoundingConverter), 6)] public decimal TerminalValuePresentValuePercent { get; set; }
        public decimal NetPresentValueBeforeAcquisition { get; set; }
        public decimal AcquisitionCosts { get; set; }
        public decimal NetPresentValue { get; set; }
        public decimal RoundedNetPresentValue { get; set; }

        public CashflowDto HoldPeriodCashflow { get; set; }
        public TerminalValuationDto TerminalValuation { get; set; }
    }
}