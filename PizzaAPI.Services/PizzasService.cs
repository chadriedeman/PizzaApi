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

        public void AddPizza(Pizza pizza)
        {
            if (pizza == null)
                throw new ArgumentException("No pizza was given to AddPizza");

            _repository.Insert(pizza);

            _repository.SaveChanges();
        }

        public void UpdatePizza(int id, Pizza updatedPizza)
        {
            if (updatedPizza == null)
                throw new ArgumentException("No pizza was given to UpdatePizza");

            var pizza = _repository.GetById<Pizza>(id);

            if(pizza == null)
                throw new ArgumentException($"No pizza exists for ID: {id}");

            // TODO:
        }

        public void DeletePizza(int id)
        {
            var pizza = _repository.GetById<Pizza>(id);

            if (pizza != null)
                _repository.Delete<Pizza>(id);
        }
    }
}
