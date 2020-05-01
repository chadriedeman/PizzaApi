using PizzaAPI.Data.Models;
using System.Collections.Generic;

namespace PizzaAPI.Data.Repositories
{
    /// <summary>
    ///  This class is where I would encapsulate the logic to access a database, query
    ///  for pizza orders, add new pizza orders to the appropriate table, etc.
    ///  
    /// </summary>
    public class OrdersRepository : IOrdersRepository
    {
        private readonly string _dbConnectionString;

        public OrdersRepository(string dbConnectionString)
        {
            _dbConnectionString = dbConnectionString;
        }

        public void CreateNewOrder(PizzaOrder pizzaOrder)
        {
            throw new System.NotImplementedException(); 
        }

        public List<PizzaOrder> GetPizzaOrders()
        {
            throw new System.NotImplementedException();
        }
    }
}
