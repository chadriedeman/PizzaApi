using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaAPI.Data.Models;

namespace PizzaAPI.Tests.Services.OrdersServiceTests.CreateNewOrderTests
{
    [TestClass]
    public class WhenCreateNewOrderWithValidPizzaOrder : OrdersServiceTestBase
    {
        private PizzaOrder _validPizzaOrder;

        private int _numberOfPizzaOrdersBeforeNewOrder = 0;

        public WhenCreateNewOrderWithValidPizzaOrder()
        {
            Arrange();
            Act();
        }

        public override void Arrange()
        {
            base.Arrange();

            _numberOfPizzaOrdersBeforeNewOrder = _mockOrdersRepository.GetPizzaOrders().Count;

            _validPizzaOrder = new PizzaOrder
            {
                OrderId = 1,
                PizzaId = 1,
                Size = "Medium",
                Pizza = new Pizza()
            };
        }

        public override void Act()
        {
            _ordersService.CreateNewOrder(_validPizzaOrder);
        }

        [TestMethod]
        public void ThenPizzaOrderShouldBeAdded()
        {
            (_mockOrdersRepository.GetPizzaOrders().Count).Should().BeGreaterThan(_numberOfPizzaOrdersBeforeNewOrder);
        }
    }
}
