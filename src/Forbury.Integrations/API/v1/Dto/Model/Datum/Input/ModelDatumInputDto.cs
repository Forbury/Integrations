﻿using Forbury.Integrations.API.v1.Dto.Model.Datum.Input.Enums;
using Forbury.Integrations.API.v1.Dto.Model.Datum.Input.Space;
using Forbury.Integrations.API.v1.Dto.Model.Interfaces;
using Forbury.Integrations.Helpers.Converters;
using System;
using System.Collections.Generic;
using Forbury.Integrations.API.v1.Dto.Model.Datum.Input.Market;
using Newtonsoft.Json;

namespace Forbury.Integrations.API.v1.Dto.Model.Datum.Input
{
    public class ModelDatumInputDto : IModelInput
    {
        public DatumSettingsDto Settings { get; set; }
        public List<DatumSpaceDto> Spaces { get; set; } = new List<DatumSpaceDto>();
        public List<DatumMarketLeasingAssumptionsDto> MarketLeasingAssumptions { get; set; }

        public string ExternalId { get; set; }
        [JsonConverter(typeof(DateFormatConverter), JsonFormats.DateFormat)] public DateTime? AcquisitionDate { get; set; }
        public int? HoldPeriodMonths { get; set; }
        public EntryExitTypes? EntryMethod { get; set; }
        public EntryExitTypes? ExitMethod { get; set; }
        public decimal? EntryTarget { get; set; }
        public decimal? ExitTarget { get; set; }
    }
}