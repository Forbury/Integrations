using Forbury.Integrations.API.v1.Dto.Model.Commercial.Input.Enums;
using Forbury.Integrations.API.v1.Dto.Model.Commercial.Input.Space.Lease;
using Forbury.Integrations.API.v1.Dto.Model.Commercial.Input.Space.Market;
using Forbury.Integrations.API.v1.Dto.Model.Commercial.Input.Space.Renewal;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Forbury.Integrations.API.v1.Dto.Model.Commercial.Input.Space
{
    public class SpaceDto
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public RentBasisType RentBasis { get; set; }
        public decimal? LettableArea { get; set; }
        public int? CarBays { get; set; }
        public string Level { get; set; }
        public string Suite { get; set; }
        public string FloorAreaType { get; set; }
        public string ViewAspect { get; set; }
        public LeaseDto Lease { get; set; }
        public FirstRenewalDto FirstRenewal { get; set; }
        public MarketAssumptionDto MarketAssumption { get; set; }
        public string RenewalAssumptionName { get; set; }
    }
}
