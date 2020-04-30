using PizzaAPI.Services;

namespace PizzaAPI.Tests.Services.OrdersServiceTests
{
    public abstract class OrdersServiceTestBase : IArrangeActAssert
    {

        protected OrdersService _ordersService;

        public virtual void Arrange()
        {
            var repositoryMock = new MockOrdersRepository();

            _ordersService = new OrdersService(repositoryMock);
        }

        public abstract void Act();
    }
}
