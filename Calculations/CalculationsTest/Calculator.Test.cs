using Calculations;
using Xunit;
using Xunit.Abstractions;

namespace CalculationsTest
{
    //Add fixture to not make a new instance of the object for each test
    public class CalculatorFixture
    {
        public Calculator Calculator => new Calculator();
    }

    public class CalculatorTest : IClassFixture<CalculatorFixture>
    {
        private readonly CalculatorFixture _calculator;
        private readonly ITestOutputHelper _testOutputHelper;

        public CalculatorTest(CalculatorFixture calculatorFixture, ITestOutputHelper testOutputHelper)
        {
            _calculator = calculatorFixture;
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        [Trait("Category", "Calculator")]
        public void Add_giventwoValues_ReturnDouble()
        {
            _testOutputHelper.WriteLine("Test start at {0}",DateTime.Now);
            //Arrange
            var calcClass = _calculator.Calculator;
            //Act
            var result = calcClass.addDouble(1.50, 0.5);
            //Acert
            Assert.Equal(2, result);
        }

        [Fact]
        [Trait("Category", "Calculator")]
        public void Add_giventwoValues_ReturnInt()
        {
            //Arrange
            var calcClass = _calculator.Calculator;
            //Act
            var result = calcClass.add(1, 5);
            //Acert
            Assert.Equal(6, result);
        }
    }
}