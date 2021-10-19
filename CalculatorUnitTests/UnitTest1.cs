using System;
using Xunit;
using CalculatorTest;

namespace CalculatorUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void AddTest()
        {
            Calculator calculator = new();

            int actualResult = calculator.Add(5, 5);
            int expectedResult = 5 + 5;

            Assert.Equal(expectedResult, actualResult);
        }
    }
}
