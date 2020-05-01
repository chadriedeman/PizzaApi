using PizzaAPI.Data.Models;
using System.Collections.Generic;

namespace PizzaAPI.Data.Repositories
{
    public interface IOrdersRepository
    {
        void CreateNewOrder(PizzaOrder pizzaOrder);
        List<PizzaOrder> GetPizzaOrders();
    }
}
