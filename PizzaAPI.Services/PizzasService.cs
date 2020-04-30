using PizzaAPI.Data;
using PizzaAPI.Data.Models;
using PizzaAPI.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaAPI.Services
{
    public class PizzasService : IPizzasService
    {
        private readonly IRepository<PizzaContext> _repository;

        public PizzasService(IRepository<PizzaContext> repository)
        {
            _repository = repository;
        }

        public List<Pizza> GetPizzas()
        {

            return _repository.Get<Pizza>()
                .ToList();
        }

        public void AddPizza()
        {
            throw new NotImplementedException();
        }

        public void UpdatePizza(int id)
        {
            throw new NotImplementedException();
        }

        public void DeletePizza(int id)
        {
            throw new NotImplementedException();
        }
    }
}
