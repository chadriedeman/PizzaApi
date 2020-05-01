using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaAPI.Tests.Services.OrdersServiceTests.GetPizzaOrdersTests
{
    [TestClass]
    public class WhenGetPizzaOrders : OrdersServiceTestBase
    {
        private int _expected;
        private int _actual;

        public WhenGetPizzaOrders()
        {
            Arrange();
            Act();
        }

        public override void Arrange()
        {
            base.Arrange();

            _expected = 3;
        }

        public override void Act()
        {
            _actual = _ordersService.GetPizzaOrders().Count;
        }

        [TestMethod]
        public void ThenAllPizzaOrderShouldBeReturned()
        {
            _expected.Should().Be(_actual);
        }
    }
}
