using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forbury.Integrations.API.v1.Dto.Model.Commercial.Input.Outgoings
{
    public class OutgoingsRecoveryDto
    {
        public string Code { get; set; }
        public decimal AllocationPercentage { get; set; }
        public decimal AdjustAmount { get; set; }
        public decimal AdoptedArea { get; set; }
    }
}