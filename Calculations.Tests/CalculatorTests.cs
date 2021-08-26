using System;
using Xunit;

namespace Calculations.Tests
{
    public class CalculatorFixture
    {
        public Calculator Calculator = new Calculator();
    }
    public class CalculatorTests : IClassFixture<CalculatorFixture>
    {
        private readonly CalculatorFixture _calculatorFixture;

        public CalculatorTests(CalculatorFixture calculatorFixture)
        {
            _calculatorFixture = calculatorFixture;
        }

        [Fact]
        [Trait("Category", "Calculator")]
        public void Add_GivenTwoIntValues_ReturnsInt()
        {
            // Arrange
            var calc = _calculatorFixture.Calculator;
            
            // Act
            var result = calc.Add(1, 2);

            // Assert 
            Assert.Equal(3, result);
        }

        [Fact]
        [Trait("Category", "Calculator")]
        public void Add_GivenTwoDoubleValues_ReturnsDouble()
        {
            var calc = _calculatorFixture.Calculator;
            var result = calc.AddDouble(1.23, 3.55);

            Assert.Equal(4.7, result, 0);
        }
    }
}
