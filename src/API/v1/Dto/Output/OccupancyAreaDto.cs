using System.Collections.Generic;
using Forbury.Integrations.Helpers.Converters;
using Newtonsoft.Json;

namespace Forbury.Integrations.API.v1.Dto.Output
{
    public class OccupancyAreaDto
    {
        public List<RenewalTypeAreaDto> RenewalTypeAreas { get; set; }
        public decimal SiteArea { get; set; }
        public decimal LettableArea { get; set; }
        public decimal OccupiedArea { get; set; }
        public decimal VacantArea { get; set; }

        [JsonConverter(typeof(DecimalRoundingConverter), 6)] public decimal VacancyIncomePercent { get; set; }
        public decimal CarBays { get; set; }

        [JsonConverter(typeof(DecimalRoundingConverter), 4)] public decimal WALEByIncome { get; set; }
        [JsonConverter(typeof(DecimalRoundingConverter), 4)] public decimal WALEByArea { get; set; }
    }
}