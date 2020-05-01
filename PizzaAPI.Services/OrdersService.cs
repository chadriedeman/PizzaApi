using PizzaAPI.Data.Models;
using PizzaAPI.Data.Repositories;
using System;
using System.Collections.Generic;

namespace PizzaAPI.Services
{
    public class OrdersService : IOrdersService
    {
        private readonly IOrdersRepository _repository;

        public OrdersService(IOrdersRepository repository)
        {
            _repository = repository;
        }

        public void CreateNewOrder(PizzaOrder pizzaOrder)
        {
            if (pizzaOrder == null)
                throw new ArgumentException("No pizza order was given to CreateNewOrder");

            _repository.CreateNewOrder(pizzaOrder);
        }

        public List<PizzaOrder> GetPizzaOrders()
        {
            return _repository.GetPizzaOrders();
        }
    }
}
