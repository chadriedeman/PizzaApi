using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using PizzaAPI.Data.Models;
using PizzaAPI.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace PizzaAPI.Controllers
{
    [Route("[controller]")]
    public class PizzasController : ControllerBase
    {
        private readonly IPizzasService _pizzasService;
        private readonly ILogger<PizzasController> _logger;

        public PizzasController(IPizzasService pizzasService, ILogger<PizzasController> logger)
        {
            _pizzasService = pizzasService;
            _logger = logger;
        }

        [HttpGet()]
        public List<Pizza> GetPizzas()
        {
            try
            {
                return _pizzasService.GetPizzas();
            }
            catch (Exception ex)
            {
                _logger.LogError($"An error occurred in GetPizzas: {ex.Message}");
                return new List<Pizza>();
            }
        }

        [HttpPost()]
        public async Task<IActionResult> AddPizza()
        {
            try
            {
                using var reader = new StreamReader(Request.Body, Encoding.UTF8);

                var requestBodyAsJsonString = await reader.ReadToEndAsync();

                if (string.IsNullOrWhiteSpace(requestBodyAsJsonString))
                    throw new ArgumentException("No request body was given to AddPizza");

                var pizza = JsonConvert.DeserializeObject<Pizza>(requestBodyAsJsonString);

                _pizzasService.AddPizza(pizza);

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError($"An error occurred in AddPizza: {ex.Message}");
                return BadRequest();
            }
        }

        [HttpPut("/{id}")]
        public IActionResult UpdatePizza(int id)
        {
            try
            {
                // TODO

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError($"An error occurred in UpdatePizza for ID {id}: {ex.Message}");
                return BadRequest();
            }
        }

        [HttpDelete("/{id}")]
        public IActionResult DeletePizza(int id)
        {
            try
            {
                // TODO

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError($"An error occurred in DeletePizza for ID {id}: {ex.Message}");
                return BadRequest();
            }
        }
    }
}
