using System;
using System.IO;
using System.Text;
using Xunit;

namespace pliantcv_json_engine.test
{
    public class SchemaValidatorTests
    {
        private const string schemaPath = "Schemas/valid-complete.json";

        [Fact]
        public void ValidJson_ShouldReturn_True()
        {
            //Arrange
            string json = string.Empty;
            var schemaValidator = new pliantcv_json_engine.api.SchemaValidator.SchemaValidator();
            var resourceStream = pliantcv_json_engine.api.Utility.IO.EmbeddedResourceAsStream(schemaPath);
            using (var fileStream = new StreamReader(resourceStream, Encoding.UTF8)) {
                json = fileStream.ReadToEnd();
            }

            //Act
            var result = schemaValidator.Validate(json);

            //Assert
            Assert.True(result);
        }
    }
}