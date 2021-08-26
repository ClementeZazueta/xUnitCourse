using System;
using Xunit;

namespace Calculations.Tests
{
    [Collection("Customer")]
    public class CustomerDetailsTests
    {
        private readonly CustomerFixture _customerFixture;

        public CustomerDetailsTests(CustomerFixture customerFixture)
        {
            _customerFixture = customerFixture;
        }

        [Fact]
        [Trait("Category", "CustomerDetails")]
        public void GetFullName_GivenFirstAndLastName_ReturnsFullName()
        {
            var customer = _customerFixture.Customer;
            var result = customer.GetFullName("Carlos", "Zazueta");

            Assert.False(string.IsNullOrEmpty(result));
            Assert.Equal("Carlos Zazueta", result, ignoreCase: true);
        }
    }
}
