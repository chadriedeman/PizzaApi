using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaAPI.Data.Models;
using System;

namespace PizzaAPI.Tests.Services.OrdersServiceTests.CreateNewOrderTests
{
    public class WhenCreateNewOrderWithValidPizzaOrder : OrdersServiceTestBase
    {
        private PizzaOrder _validPizzaOrder;

        public WhenCreateNewOrderWithValidPizzaOrder()
        {
            Arrange();
            Act();
        }

        public override void Arrange()
        {
            base.Arrange();

            _validPizzaOrder = new PizzaOrder
            {
                // TODO
            };
        }

        public override void Act()
        {
            _ordersService.CreateNewOrder(_validPizzaOrder);
        }

        [TestMethod]
        public void ThenPizzaOrderShouldHaveBeenAdded()
        {

        }
    }
}
