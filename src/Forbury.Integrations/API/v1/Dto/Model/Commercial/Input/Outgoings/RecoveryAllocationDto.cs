using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forbury.Integrations.API.v1.Dto.Model.Commercial.Input.Outgoings
{
    public class RecoveryAllocationDto
    {
        public string RecoveryProfileCode { get; set; }
        public decimal ManualAllocation { get; set; }
        public decimal ManualAdjust { get; set; }
        public decimal AdoptedArea { get; set; }
    }
}