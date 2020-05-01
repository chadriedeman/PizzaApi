using PizzaAPI.Data.Models;
using PizzaAPI.Data.Repositories;
using System.Collections.Generic;

namespace PizzaAPI.Tests.Services.OrdersServiceTests
{
    public class MockOrdersRepository : IOrdersRepository
    {
        private List<PizzaOrder> _pizzaOrders;

        public MockOrdersRepository()
        {
            _pizzaOrders = new List<PizzaOrder>
            {
                new PizzaOrder
                {
                    OrderId = 1,
                    PizzaId = 1,
                    Pizza = new Pizza
                    {
                        // TODO
                    },
                    Size = "Small"
                },
                new PizzaOrder
                {
                    OrderId = 1,
                    PizzaId = 2,
                    Pizza = new Pizza
                    {
                        // TODO
                    },
                    Size = "Small"
                },
                new PizzaOrder
                {
                    OrderId = 2,
                    PizzaId = 3,
                    Pizza = new Pizza
                    {
                        // TODO
                    },
                    Size = "Large"
                }
            };
        }

        public void CreateNewOrder(PizzaOrder pizzaOrder)
        {
            _pizzaOrders.Add(pizzaOrder);
        }

        public List<PizzaOrder> GetPizzaOrders()
        {
            return _pizzaOrders;
        }
    }
}
