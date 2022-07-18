using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Forbury.Integrations.Helpers.Converters
{
    public class DecimalRoundingConverter : JsonConverter
    {
        private readonly int _precision;
        private readonly MidpointRounding _rounding;

        public DecimalRoundingConverter(int precision)
            : this(precision, MidpointRounding.AwayFromZero)
        {
        }

        public DecimalRoundingConverter(int precision, MidpointRounding rounding)
        {
            _precision = precision;
            _rounding = rounding;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(decimal) || objectType == typeof(decimal?);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JToken token = JToken.Load(reader);

            if (token.Type == JTokenType.Null && objectType == typeof(decimal?))
                return null;

            decimal result = token.Type == JTokenType.Float || token.Type == JTokenType.Integer ?
                token.ToObject<decimal>() :
                decimal.Parse(token.ToString());

            return Math.Round(result, _precision, _rounding);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null) return;
            writer.WriteValue(Math.Round((decimal)value, _precision, _rounding));
        }
    }
}
