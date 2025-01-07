
using Microsoft.AspNetCore.Mvc;

namespace CadeRBackendAdd2Numbers.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddingNumbersController : ControllerBase
    {
        [HttpGet]
        [Route("Adding/{num1}/{num2}")]
        public string AddTwoNumbers(int num1, int num2)
        {
            int total = num1 + num2;

            return $"The sum of {num1} + {num2} is equivalent to {total}";
        }
    }
}