using Microsoft.AspNetCore.Mvc;

namespace CalculatorApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        [HttpGet("add")]
        public ActionResult<decimal> Add(decimal x, decimal y)
        {
            return Ok(x + y);
        }

        [HttpGet("subtract")]
        public ActionResult<decimal> Subtract(decimal x, decimal y)
        {
            return Ok(x - y);
        }

        [HttpGet("multiply")]
        public ActionResult<decimal> Multiply(decimal x, decimal y)
        {
            return Ok(x * y);
        }

        [HttpGet("divide")]
        public ActionResult<decimal> Divide(decimal x, decimal y)
        {
            if (y == 0)
                return BadRequest("Division by zero is not allowed.");
            return Ok(x / y);
        }

        [HttpGet("modulo")]
        public ActionResult<decimal> Modulo(decimal x, decimal y)
        {
            return Ok(x % y);
        }
    }
}
