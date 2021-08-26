using System;
using Xunit;

namespace Calculations.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_GivenTwoIntValues_ReturnsInt()
        {
            // Arrange
            var calc = new Calculator();
            
            // Act
            var result = calc.Add(1, 2);

            // Assert 
            Assert.Equal(3, result);
        }

        [Fact]
        public void Add_GivenTwoDoubleValues_ReturnsDouble()
        {
            var calc = new Calculator();
            var result = calc.AddDouble(1.23, 3.55);

            Assert.Equal(4.7, result, 0);
        }
    }
}
