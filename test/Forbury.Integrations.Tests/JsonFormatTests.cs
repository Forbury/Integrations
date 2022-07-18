using Forbury.Integrations.API;
using Forbury.Integrations.API.v1.Dto.Model.Input.General;
using Newtonsoft.Json;
using NUnit.Framework;
using System;

namespace Forbury.Integrations.Tests
{
    public class Tests
    {
        [Test]
        public void JsonDateFormatTest()
        {
            // Starting values
            var now = DateTime.Now;
            var generalDto = new GeneralDto()
            {
                ValuationDate = now
            };

            // Create a serialized string and deserialize object again
            var jsonString = JsonConvert.SerializeObject(generalDto);
            var deserializedGeneralDto = JsonConvert.DeserializeObject<GeneralDto>(jsonString);

            // Check object is not null, format was maintained, and value can be converted back correctly
            Assert.That(deserializedGeneralDto.ValuationDate, Is.Not.Null);
            Assert.AreEqual(now.Date, deserializedGeneralDto.ValuationDate.Value.Date);
            StringAssert.Contains(now.Date.ToString(JsonFormats.DateFormat), jsonString);
        }
    }
}