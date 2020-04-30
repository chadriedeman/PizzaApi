using PizzaAPI.Data.Models;

namespace PizzaAPI.Services
{
    public interface IOrdersService
    {
        void CreateNewOrder(PizzaOrder pizzaOrder);
    }
}
