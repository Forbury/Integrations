using System;
using System.Collections.Generic;

namespace Forbury.Integrations.API.v1.Dto.Model.Datum.Input
{
    public enum EntryExitTypes
    {
        Price = 0,
        NIY = 1,
        RY = 2,
        NIYFL = 3,
        EY = 4
    }

    public enum ReviewTypes
    {
        OMV = 0,
        CPI = 1,
        Amount = 2,
        Percent = 3
    }

    public class ModelDatumInputDto
    {
        public List<SpaceInputDto> Spaces { get; set; }

        public DateTime? ValuationDate { get; set; }
        public int? HoldPeriodMonths { get; set; }
        public EntryExitTypes? EntryMethod { get; set; }
        public EntryExitTypes? ExitMethod { get; set; }
        public decimal? EntryTarget { get; set; }
        public decimal? ExitTarget { get; set; }
    }

    public class SpaceInputDto
    {
        public TenantInputDto Tenant { get; set; }

        public decimal? MarketRent { get; set; }
        public decimal? LettableArea { get; set; }
    }

    public class TenantInputDto
    {
        public string Name { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public decimal? BaseRent { get; set; }
        //public List<TenantReviewInputDto> Reviews { get; set; }
    }

    public class TenantReviewInputDto
    {
        public ReviewTypes Type { get; set; }
        public decimal? Amount { get; set; }
        public DateTime Date { get; set; }
    }
}