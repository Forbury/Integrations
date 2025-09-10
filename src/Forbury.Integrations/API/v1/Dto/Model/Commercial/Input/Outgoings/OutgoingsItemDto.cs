using System.Collections.Generic;

namespace Forbury.Integrations.API.v1.Dto.Model.Commercial.Input.Outgoings
{
    public class OutgoingsItemDto
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string PcaCategory { get; set; }
        public bool? IsRecoverable { get; set; }
        public string GrowthRateName { get; set; }
        public decimal? PreviousBudget { get; set; }
        public decimal? CurrentBudget { get; set; }
        public decimal? AdoptedBudget { get; set; }
        public RecoveryAllocationDto RecoveryAllocation { get; set; }
    }
}