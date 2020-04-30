using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using PizzaAPI.Data.Models;
using PizzaAPI.Services;
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

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

        [HttpPost()]
        public async Task<IActionResult> CreateNewOrder()
        {
            try
            {
                using var reader = new StreamReader(Request.Body, Encoding.UTF8);

                var requestBodyAsJsonString = await reader.ReadToEndAsync();

                if (string.IsNullOrWhiteSpace(requestBodyAsJsonString))
                    throw new ArgumentException("No request body was given to AddPizza");

                var pizzaOrder = JsonConvert.DeserializeObject<PizzaOrder>(requestBodyAsJsonString);

                _ordersService.CreateNewOrder(pizzaOrder);

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError($"An error occurred in CreateNewOrder: {ex.Message}");
                return BadRequest();
            }
        }
    }
}
