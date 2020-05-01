using PizzaAPI.Data.Repositories;
using PizzaAPI.Services;

namespace PizzaAPI.Tests.Services.OrdersServiceTests
{
    public abstract class OrdersServiceTestBase : IArrangeActAssert
    {
        protected IOrdersRepository _mockOrdersRepository;

        protected OrdersService _ordersService;

        public virtual void Arrange()
        {
            _mockOrdersRepository = new MockOrdersRepository();

            _ordersService = new OrdersService(_mockOrdersRepository);
        }

        public abstract void Act();
    }
}
