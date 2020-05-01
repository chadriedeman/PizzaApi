using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaAPI.Data.Models;
using System;

namespace PizzaAPI.Tests.Services.OrdersServiceTests.CreateNewOrderTests
{
    [TestClass]
    public class WheCreateNewOrderWithInvalidPizzaOrder : OrdersServiceTestBase
    {
        private PizzaOrder _invalidPizzaOrder;

        private int _numberOfPizzaOrdersBeforeNewOrder = 0;
        private bool _exceptionOccurred = false;

        public WheCreateNewOrderWithInvalidPizzaOrder()
        {
            Arrange();
            Act();
        }

        public override void Arrange()
        {
            base.Arrange();

            _numberOfPizzaOrdersBeforeNewOrder = _mockOrdersRepository.GetPizzaOrders().Count;

            _invalidPizzaOrder = null;
        }

        public override void Act()
        {
            try
            {
                _ordersService.CreateNewOrder(_invalidPizzaOrder);
            }
            catch (ArgumentException ex)
            {
                _exceptionOccurred = true;
            }
        }

        [TestMethod]
        public void ThenAnArgumentExceptionShouldBeThrown()
        {
            _exceptionOccurred.Should().BeTrue();
        }

        [TestMethod]
        public void ThenNoPizzaOrderShouldBeAdded()
        {
            (_mockOrdersRepository.GetPizzaOrders().Count).Should().Be(_numberOfPizzaOrdersBeforeNewOrder);
        }
    }
}
