using Newtonsoft.Json.Converters;

namespace Forbury.Integrations.Helpers.Converters
{
    public class DateFormatConverter : IsoDateTimeConverter
    {
        public DateFormatConverter(string format)
        {
            DateTimeFormat = format;
        }
    }
}
