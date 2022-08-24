using CalculadoraLib;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculadoraController : ControllerBase
    {
        private readonly ILogger<CalculadoraController> _logger;

        private readonly Calculadora _calculadora;

        public CalculadoraController(ILogger<CalculadoraController> logger)
        {
            _logger = logger;
            _calculadora = new Calculadora();

        }

        [HttpGet("somar/{num1}/{num2}")]
        public ActionResult<int> Somar(int num1, int num2)
        {
            return _calculadora.Somar(num1, num2);
        }

        [HttpGet("subtrair/{num1}/{num2}")]
        public ActionResult<int> Subtrair(int num1, int num2)
        {
            return _calculadora.Subtrair(num1, num2);
        }

        [HttpGet("multiplicar/{num1}/{num2}")]
        public ActionResult<int> Multiplicar(int num1, int num2)
        {
            return _calculadora.Multiplicar(num1, num2);
        }

        [HttpGet("dividir/{num1}/{num2}")]
        public ActionResult<int> Dividir(int num1, int num2)
        {
            return _calculadora.Dividir(num1, num2);
        }
    }
}
