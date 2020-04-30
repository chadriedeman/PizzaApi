using PizzaAPI.Data.Models;

namespace PizzaAPI.Data.Repositories
{
    public interface IOrdersRepository
    {
        void CreateNewOrder(PizzaOrder pizzaOrder);
    }
}
