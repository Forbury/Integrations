using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forbury.Integrations.API.v1.Dto.Model.Commercial.Input.General
{
    public class DiscountedCashflowInputDto
    {
        public decimal? TerminalBudgetedCapexAllowanceMonths { get; set; }

        public decimal? TerminalSinkingFundAllowanceMonths { get; set; }
    }
}
