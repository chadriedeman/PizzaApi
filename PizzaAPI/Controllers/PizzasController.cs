using Microsoft.AspNetCore.Mvc;

namespace PizzaAPI.Controllers
{
    [Route("[controller]")]
    public class PizzasController : ControllerBase
    {
        [HttpGet("[action]")]
        public IActionResult GetPizzas()
        {
            return Ok("Hello World");
        }

    }
}
