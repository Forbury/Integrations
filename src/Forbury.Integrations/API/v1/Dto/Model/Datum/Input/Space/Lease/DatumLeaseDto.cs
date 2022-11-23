using System;

namespace Forbury.Integrations.API.v1.Dto.Model.Datum.Input.Space.Lease
{
    public class DatumLeaseDto
    {
        public string Name { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public decimal? BaseRent { get; set; }
        public DateTime? BreakDate { get; set; }
        public bool? IsBreakActive { get; set; }
    }
}
