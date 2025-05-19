using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forbury.Integrations.API.v1.Dto.Model.Retail.Input.Space.Lease.MovingAnnualTurnover
{
    public class MovingAnnualTurnoverDto
    {
        /// <summary>
        /// True - GST Inclusive or False - Exclusive
        /// </summary>
        public bool Prior12MonthsGstInclusive { get; set; }

        /// <summary>
        /// True - GST Inclusive or False - Exclusive
        /// </summary>
        public bool Last12MonthsGstInclusive { get; set; }
    }
}
