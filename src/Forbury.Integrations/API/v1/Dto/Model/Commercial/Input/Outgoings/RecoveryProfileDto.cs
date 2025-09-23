using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forbury.Integrations.API.v1.Dto.Model.Commercial.Input.Outgoings
{
    public class RecoveryProfileDto
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal? AdoptedArea { get; set; }
        public decimal? FirstManualAdjustment { get; set; }
        public decimal? SecondManualAdjustment { get; set; }
    }
}