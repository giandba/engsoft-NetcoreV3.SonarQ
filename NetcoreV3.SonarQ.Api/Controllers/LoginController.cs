using Microsoft.AspNetCore.Mvc;
using NetcoreV3.SonarQ.Apps.Interfaces;

namespace NetcoreV3.SonarQ.Api.Controllers
{

    [Route("api")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IConexaoDB _conexaoDB;
        
        [HttpPost]
        public IActionResult Login()
        {           
            var result = _conexaoDB.ValidaLogin("teste", "teste123");
            return base.Ok(result);
        }
    }
}