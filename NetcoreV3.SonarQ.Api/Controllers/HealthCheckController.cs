using Microsoft.AspNetCore.Mvc;

namespace NetcoreV3.SonarQ.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthCheckController : ControllerBase
    {        
        [HttpGet]
        public IActionResult HealthCheck()
        {
            return base.Ok(new {status=true});
        }
    }
}