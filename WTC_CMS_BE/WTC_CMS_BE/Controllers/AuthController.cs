

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WTC_CMS_BE.API.Middlewares;

namespace WTC_CMS_BE.API.Controllers
{
    [Route("api/AuthController")]
    public class AuthController: ControllerBase 
    {
        private readonly ICustomLoggingMiddleware _customLoggingMiddleware;

        public AuthController(ICustomLoggingMiddleware customLoggingMiddleware)
        {
            _customLoggingMiddleware = customLoggingMiddleware;
        }

        [HttpGet]
        //[Authorize]
        [Route("HealthCheck")]
        public async Task<ActionResult<string>> HealthCheckEndPoint(int check)
        {
            string output = "Health Check";

            await _customLoggingMiddleware.LogDummyExceptions(output);

            return output;
        }



    }
}
