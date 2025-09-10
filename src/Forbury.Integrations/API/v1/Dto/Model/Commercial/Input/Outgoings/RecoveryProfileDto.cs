using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forbury.Integrations.API.v1.Dto.Model.Commercial.Input.Outgoings
{
    public class RecoveryProfileDto
    {
        public string RecoveryProfileCode { get; set; }
        public string RecoveryProfileDescription { get; set; }
        public decimal RecoveryProfileAdoptedArea { get; set; }
    }
}