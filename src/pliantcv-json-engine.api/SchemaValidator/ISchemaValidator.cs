//SDK
using System;

namespace pliantcv_json_engine.api.SchemaValidator
{
    public interface ISchemaValidator
    {
        bool Validate(string json);
    }
}