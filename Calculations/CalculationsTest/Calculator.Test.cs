﻿using Calculations;
using Xunit;

namespace CalculationsTest
{
    public class CalculatorTest
    {
        [Fact]
        public void TestAdd()
        {
            Assert.True(true);
        }

        [Fact]
        public void Add_giventwoValues_ReturnDouble()
        {
            //Arrange
            Calculator calcClass = new Calculator();
            //Act
            var result = calcClass.addDouble(1.50, 0.5);
            //Acert
            Assert.Equal(2, result);
        }

        [Fact]
        public void Add_giventwoValues_ReturnInt()
        {
            //Arrange
            Calculator calcClass = new Calculator();
            //Act
            var result = calcClass.add(1, 5);
            //Acert
            Assert.Equal(6, result);
        }
    }
}