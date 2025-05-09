using System;
using System.Collections.Generic;
using Forbury.Integrations.Helpers.Converters;
using Newtonsoft.Json;

namespace Forbury.Integrations.API.v1.Dto.Model.Retail.Input.Outgoings
{
    public class OutgoingsDto
    {
        [JsonConverter(typeof(DateFormatConverter), JsonFormats.DateFormat)]
        public DateTime? OutgoingsDate { get; set; }
        public List<OutgoingsItemDto> Items { get; set; }
    }
}
