using PizzaAPI.Data.Models;
using System.Collections.Generic;

namespace PizzaAPI.Services
{
    public interface IOrdersService
    {
        void CreateNewOrder(PizzaOrder pizzaOrder);
        List<PizzaOrder> GetPizzaOrders();
    }
}
