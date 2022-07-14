using Calculations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CalculationsTest
{
    public class FibonacciFixture
    {
        public FibonacciSeries Fibo => new FibonacciSeries();
    }
    public class FibonacciTests:IClassFixture<FibonacciFixture>
    {
        private readonly FibonacciFixture _fixture;
        public FibonacciTests(FibonacciFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void Fibonacci_hasNoZero()
        {
            //Arrange
            var result = _fixture.Fibo.Fibonacci;
            //Act

            //Assert
            Assert.All(result, n => Assert.NotEqual(0, n));
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void Fibonacci_has13()
        {
            //Arrange
            var result = _fixture.Fibo.Fibonacci;
            //Act
            //Assert
            Assert.Contains(13,result);
        }


        [Fact]
        [Trait("Category", "Fibo")]
        public void Fibonacci_hasNo4()
        {
            //Arrange
            var result = _fixture.Fibo.Fibonacci;
            //Act
            //Assert
            Assert.DoesNotContain(4, result);
        }
    }
}
