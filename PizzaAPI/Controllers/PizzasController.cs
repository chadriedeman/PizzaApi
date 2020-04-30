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
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                // TODO: Log
                return new List<Pizza>();
            }
        }
    }
}
