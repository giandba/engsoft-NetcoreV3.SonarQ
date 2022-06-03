using Microsoft.AspNetCore.Mvc;
using NetcoreV3.SonarQ.Apps.Interfaces;

namespace NetcoreV3.SonarQ.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IConexaoDB _conexaoDB;
        
        [HttpPost("service")]
        public IActionResult LoginService()
        {           
            var result = _conexaoDB.ValidaLogin("teste", "teste123");
            return base.Ok(result);
        }

        [HttpPost("mobile")]
        public IActionResult LoginMobile()
        {           
            var result = _conexaoDB.ValidaLogin("teste", "teste123");
            return base.Ok(result);
        }
    }
}