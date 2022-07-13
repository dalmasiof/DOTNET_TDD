using Calculations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CalculationsTest
{
    public class FibonacciTests
    {
        [Fact]
        public void Fibonacci_hasNoZero()
        {
            //Arrange
            FibonacciSeries fibonacci = new FibonacciSeries();
            //Act
            var result = fibonacci.Fibonacci;
            //Assert
            Assert.All(result, n => Assert.NotEqual(0, n));
        }
    }
}
