using System.Collections.Generic;

namespace Forbury.Integrations.API.v1.Dto.Model.Commercial.Input.Capex
{
    public class CapexDto
    {
        public SinkingFundDto SinkingFund { get; set; }
        public List<BudgetedCapexDto> BudgetedCapexs { get; set; }
        public RefurbishmentDto Refurbishment { get; set; }
    }
}
