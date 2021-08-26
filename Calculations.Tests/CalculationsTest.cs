using System;
using System.Collections.Generic;
using System.IO;
using Xunit;
using Xunit.Abstractions;

namespace Calculations.Tests
{
    public class CalculationsFixture
    {
        public Calculations Calc = new Calculations();
    }

    public class CalculationsTest : IClassFixture<CalculationsFixture>, IDisposable
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private readonly CalculationsFixture _calculationsFixture;
        private readonly MemoryStream _memoryStream;

        public CalculationsTest(CalculationsFixture calculationsFixture, ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
            _testOutputHelper.WriteLine("Constructor");
            _calculationsFixture = calculationsFixture;
            _memoryStream = new MemoryStream();
        }

        [Fact]
        [Trait("Category", "Fibonacci")]
        public void FibonacciDoesNotIncludeZero()
        {
            _testOutputHelper.WriteLine("FibonacciDoesNotIncludeZero");
            var calc = _calculationsFixture.Calc;
            //Assert.All(calc.FibonacciNumbers, n => Assert.NotEqual(1, n));
            //Assert.All(calc.FibonacciNumbers, n => Assert.NotEqual(0, n));
            Assert.DoesNotContain(0, calc.FibonacciNumbers);
        }

        [Fact]
        [Trait("Category", "Fibonacci")]
        public void FibonacciIncludes13()
        {
            _testOutputHelper.WriteLine("FibonacciIncludes13");
            var calc = _calculationsFixture.Calc;

            Assert.Contains(13, calc.FibonacciNumbers);
        }

        [Fact]
        [Trait("Category", "Fibonacci")]
        public void FibonacciDoesNotContain4()
        {
            _testOutputHelper.WriteLine("FibonacciDoesNotContain4");
            var calc = _calculationsFixture.Calc;

            Assert.DoesNotContain(4, calc.FibonacciNumbers);
        }

        [Fact]
        [Trait("Category", "Fibonacci")]
        public void CheckCollection()
        {
            _testOutputHelper.WriteLine($"CheckCollection. Test starting at {DateTime.Now}");
            var expectedCollection = new List<int>() { 1, 1, 2, 3, 5, 8, 13 };

            _testOutputHelper.WriteLine("Creating an instance of calculations class");
            var calc = _calculationsFixture.Calc;

            _testOutputHelper.WriteLine("Asserting...");
            Assert.Equal(expectedCollection, calc.FibonacciNumbers);

            _testOutputHelper.WriteLine("End");
        }

        //[Fact]
        //public void IsOdd_GivenOddValue_ReturnsTrue()
        //{
        //    var calc = _calculationsFixture.Calc;
        //    var result = calc.IsOdd(1);

        //    Assert.True(result);
        //}

        // For test that uses the same method and expect differetn results
        // better use Theory. Theory indicates that a test will be repeated n number if times
        [Theory]
        //[MemberData(nameof(TestDataShare.IsOddOrEvenParameterValues), MemberType = typeof(TestDataShare))]
        [IsOddOrEvenData]
        [Trait("Category", "Odd and Even")]
        public void IsOdd_TestOddAndEven(int value, bool expected)
        {
            var calc = _calculationsFixture.Calc;
            var result = calc.IsOdd(value);
            Assert.Equal(expected, result);
        }

        public void Dispose()
        {
            _memoryStream.Close();
        }
    }
}
