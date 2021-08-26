using System;
using Xunit;

namespace Calculations.Tests
{


    [Collection("Customer")]
    public class CustomerTests
    {
        private readonly CustomerFixture _customerFixture;
        public CustomerTests(CustomerFixture customerFixture)
        {
            _customerFixture = customerFixture;
        }

        [Fact]
        [Trait("Category", "Customers")]
        public void checkLegitForDiscount()
        {
            var customer = _customerFixture.Customer;
            Assert.InRange(customer.Age, 25, 40);
        }

        [Fact]
        [Trait("Category", "Customers")]
        public void GetOrdersByNameNotNull()
        {
            var customer = _customerFixture.Customer;
            var exceptionDetalis = Assert.Throws<ArgumentException>(() => customer.GetOrdersByName(""));
            Assert.Equal("Hello", exceptionDetalis.Message);
        }

        [Fact]
        [Trait("Category", "Customers")]
        public void LoyalCostumerForOrdersG100()
        {
            var costumer = CustomerFactory.CreateCustomerInstance(110);
            var loyalCostumer = Assert.IsType<LoyalCostumer>(costumer);

            Assert.Equal(10, loyalCostumer.Discount);
        }
    }
}
