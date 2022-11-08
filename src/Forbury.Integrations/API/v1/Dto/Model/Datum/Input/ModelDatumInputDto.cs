﻿using Forbury.Integrations.API.v1.Dto.Model.Datum.Input.Enums;
using Forbury.Integrations.API.v1.Dto.Model.Datum.Input.Space;
using System;
using System.Collections.Generic;

namespace Forbury.Integrations.API.v1.Dto.Model.Datum.Input
{
    public class ModelDatumInputDto : IModelInput
    {
        public List<DatumSpaceDto> Spaces { get; set; }

        public DateTime? ValuationDate { get; set; }
        public int? HoldPeriodMonths { get; set; }
        public EntryExitTypes? EntryMethod { get; set; }
        public EntryExitTypes? ExitMethod { get; set; }
        public decimal? EntryTarget { get; set; }
        public decimal? ExitTarget { get; set; }
    }
}