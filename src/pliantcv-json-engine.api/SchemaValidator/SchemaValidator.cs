//SDK
using System;
using System.IO;
using System.Text;

//Packages
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace pliantcv_json_engine.api.SchemaValidator
{
    #pragma warning disable CS0618

    public class SchemaValidator : ISchemaValidator
    {
        private const string schemaPath = "Schemas/resume-schema-v1.0.0.json";

        private readonly JsonSchema schema = null;

        public SchemaValidator()
        {
            var resourceStream = Utility.IO.EmbeddedResourceAsStream(schemaPath);

            using (var fileStream = new StreamReader(resourceStream, Encoding.UTF8))
            {
                var schemaJson = fileStream.ReadToEnd();
                schema = JsonSchema.Parse(schemaJson);
            }
        }

        public bool Validate(string json)
        {
            JObject jObject = JObject.Parse(json);
            return jObject.IsValid(schema);
        }
    }

    #pragma warning restore CS0618
}