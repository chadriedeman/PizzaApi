using PizzaAPI.Data.Models;
using System.Collections.Generic;

namespace PizzaAPI.Services
{
    public interface IPizzasService
    {
        List<Pizza> GetPizzas();
        void AddPizza(Pizza pizza);
        void UpdatePizza(int id, Pizza updatedPizza);
        void DeletePizza(int id);
    }
}
