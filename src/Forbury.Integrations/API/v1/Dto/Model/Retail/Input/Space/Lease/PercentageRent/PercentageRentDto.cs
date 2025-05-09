using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Forbury.Integrations.API.v1.Dto.Model.Retail.Input.Space.Lease.PercentageRent
{
    public class PercentageRentDto
    {
        /// <summary>
        /// The type of percentage rent (supported input - "N" for natural, "U" for unnatural)
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// The percentage for natural breakeven
        /// </summary>
        public decimal? Percentage { get; set; }

        /// <summary>
        /// Type of input for natural breakeven ("Base", "Base+Rec", "Promo")
        /// </summary>
        public string Basis { get; set; }
    }
}
