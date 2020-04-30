using PizzaAPI.Data;
using PizzaAPI.Data.Models;
using PizzaAPI.Data.Repositories;
using System;

namespace PizzaAPI.Services
{
    public class OrdersService : IOrdersService
    {
        private readonly IRepository<PizzaContext> _repository;

        public OrdersService(IRepository<PizzaContext> repository)
        {
            _repository = repository;
        }

        public void CreateNewOrder(PizzaOrder pizzaOrder)
        {
            if (pizzaOrder == null)
                throw new ArgumentException("No pizza order was given to CreateNewOrder");

            _repository.Insert(pizzaOrder);
        }
    }
}
