using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PizzaAPI.Services;

namespace PizzaAPI.Controllers
{
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly IOrdersService _ordersService;
        private readonly ILogger<OrdersController> _logger;

        public OrdersController(IOrdersService ordersService, ILogger<OrdersController> logger)
        {
            _ordersService = ordersService;
            _logger = logger;
        }

        [HttpPost("[action]")]
        public IActionResult CreateNewOrder()
        {
            try
            {
                // TODO

                return Ok();
            }
            catch
            {
                // TOOD: Log
                return BadRequest();
            }
        }
    }
}
