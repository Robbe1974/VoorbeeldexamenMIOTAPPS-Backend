using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Opdracht1Backend.Modules;
namespace Opdracht1Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

  
    public class CalculatorController : ControllerBase
    {
        [HttpPost("calculate")]
        public IActionResult Calculate([FromBody] Calculation calculation)
        {
            // Perform the calculation
            double result;
            switch (calculation.Operation)
            {
                case "+":
                    result = calculation.Number1 + calculation.Number2;
                    break;
                case "-":
                    result = calculation.Number1 - calculation.Number2;
                    break;
                case "x":
                    result = calculation.Number1 * calculation.Number2;
                    break;
                case "/":
                    result = calculation.Number1 / calculation.Number2;
                    break;
                default:
                    return BadRequest();
            }
            return Ok(result);
        }
    }
}
