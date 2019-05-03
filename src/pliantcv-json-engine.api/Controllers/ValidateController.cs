//SDK
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Packages
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

//Project
using ISchemaValidator = pliantcv_json_engine.api.SchemaValidator.ISchemaValidator;

namespace pliantcv_json_engine.api.Controllers
{
    [Route("validate")]
    [ApiController]
    [Produces("application/json")]
    public class ValidateController : ControllerBase
    {
        private ISchemaValidator _schemaValidator;

        public ValidateController(
            ISchemaValidator schemaValidator)
        {
            _schemaValidator = schemaValidator;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Post([FromBody] string json)
        {
            var result = _schemaValidator.Validate(json);
            return BadRequest();
        }
    }
}