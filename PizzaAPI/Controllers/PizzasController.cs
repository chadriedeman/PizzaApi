using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PizzaAPI.Data.Models;
using PizzaAPI.Services;
using System;
using System.Collections.Generic;

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

        [HttpGet("[action]")]
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

        [HttpPost("[action]")]
        public IActionResult AddPizza()
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

        [HttpPut("[action]/{id}")]
        public IActionResult UpdatePizza(int id)
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

        [HttpDelete("[action]/{id}")]
        public IActionResult DeletePizza(int id)
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
