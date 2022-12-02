using System.Collections.Generic;
using Forbury.Integrations.Helpers.Converters;
using Newtonsoft.Json;

namespace Forbury.Integrations.API.v1.Dto.Model.Output
{
    public class OccupancyAreaDto
    {
        public List<RenewalTypeAreaDto> RenewalTypeAreas { get; set; }
        public decimal SiteArea { get; set; }
        public decimal LettableArea { get; set; }
        public decimal OccupiedArea { get; set; }
        [JsonConverter(typeof(DecimalRoundingConverter), 6)] public decimal OccupiedPercent { get; set; }
        public decimal VacantArea { get; set; }
        [JsonConverter(typeof(DecimalRoundingConverter), 6)] public decimal VacantAreaPercent { get; set; }
        [JsonConverter(typeof(DecimalRoundingConverter), 6)] public decimal VacantIncomePercent { get; set; }
        public int VacantTenantsCount { get; set; }

        public decimal CarBays { get; set; }
        [JsonConverter(typeof(DecimalRoundingConverter), 2)] public decimal CarParkRatio { get; set; }
        [JsonConverter(typeof(DecimalRoundingConverter), 2)] public decimal LettableAreaPerCarPark { get; set; }

        [JsonConverter(typeof(DecimalRoundingConverter), 4)] public decimal WALEByIncome { get; set; }
        [JsonConverter(typeof(DecimalRoundingConverter), 4)] public decimal WALEByArea { get; set; }
    }
}