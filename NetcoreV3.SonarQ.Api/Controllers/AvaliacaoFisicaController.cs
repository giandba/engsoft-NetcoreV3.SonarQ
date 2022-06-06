using Microsoft.AspNetCore.Mvc;
using NetcoreV3.SonarQ.Apps.Interfaces;
using NetcoreV3.SonarQ.Api.Models;

namespace NetcoreV3.SonarQ.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AvaliacaoFisicaController:ControllerBase
    {
        private readonly IAvaliacaoFisica avaliacao;

        public AvaliacaoFisicaController(IAvaliacaoFisica avaliacaoFisica)
        {
            avaliacao=avaliacaoFisica;
        }

        [HttpGet("imc/altura/{altura}/peso/{peso}")]
        public IActionResult CalculaImc(string altura, string peso)
        {           
            var imc = avaliacao.CalcularIMC(double.Parse(altura),double.Parse(peso));
            return base.Ok(imc);
        }
        
        [HttpPost("imc")]
        public IActionResult CalculaImc([FromBody] AvaliacaoFisicaImcInputModel model)
        {           
            var imc = avaliacao.CalcularIMC(model.altura,model.peso);
            return base.Ok(imc);
        }
    }
}