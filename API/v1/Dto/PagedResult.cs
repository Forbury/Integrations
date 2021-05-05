using System.Collections.Generic;

namespace Forbury.Integrations.API.v1.Dto
{
    public class PagedResult<T>
    {
        public List<T> Items { get; set; }
        public int TotalItems { get; set; }
        public int RequestedAmount { get; set; }
        public int RequestPage { get; set; }
    }
}
