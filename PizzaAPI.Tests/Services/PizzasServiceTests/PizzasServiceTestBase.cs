using PizzaAPI.Services;
using System;

namespace PizzaAPI.Tests.Services.PizzasServiceTests
{
    public abstract class PizzasServiceTestBase : IArrangeActAssert
    {
        protected PizzasService _pizzasService;

        public void Arrange()
        {
            throw new NotImplementedException(); // TODO
        }

        public abstract void Act();
    }
}
