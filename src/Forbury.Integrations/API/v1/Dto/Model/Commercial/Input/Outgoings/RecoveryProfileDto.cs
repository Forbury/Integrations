using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forbury.Integrations.API.v1.Dto.Model.Commercial.Input.Outgoings
{
    public class RecoveryProfileDto
    {
        public string ProfileCode { get; set; }
        public string ProfileDescription { get; set; }
        public decimal ProfileAdoptedArea { get; set; }
        public decimal ProfileFirstManualAdjustment { get; set; }
        public decimal ProfileSecondManualAdjustment { get; set; }
    }
}