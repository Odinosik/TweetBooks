using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tweetbook.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("[controller]/[action]")]
    public abstract class ApiControllerBase : ControllerBase
    {
        public override ObjectResult StatusCode(int statusCode, object value)
        {
            AddObjectResultTypeHeader(value);
            return base.StatusCode(statusCode, value);
        }

        public override NotFoundObjectResult NotFound(object value)
        {
            AddObjectResultTypeHeader(value);
            return base.NotFound(value);
        }
        public override OkObjectResult Ok(object value)
        {
            AddObjectResultTypeHeader(value);
            return base.Ok(value);
        }
        public override BadRequestObjectResult BadRequest(object value)
        {
            AddObjectResultTypeHeader(value);
            return base.BadRequest(value);
        }

        protected void AddObjectResultTypeHeader(object value)
        {
            Response.Headers.Add("X-Result-Object-Type", value.GetType().FullName);
        }
    }
}
