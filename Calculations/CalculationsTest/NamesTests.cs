using Calculations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CalculationsTest
{
    public class NamesTests
    {
        [Fact]
        [Trait("Category", "Name")]
        public void getName_givenTwoValues_returnFullName()
        {
            //Arrange
            Names names = new Names();
            //Act
            var result = names.getName("Joao", "Pedro");
            //Assert
            Assert.Equal("Joao Pedro",result);
        }

        [Fact]
        [Trait("Category", "Name")]
        public void getName_givenTwoValues_returnContain()
        {
            //Arrange
            Names names = new Names();
            //Act
            var result = names.getName("Joao", "Pedro");
            //Assert
            Assert.Contains("Joao", result);
        }

        [Fact]
        [Trait("Category", "Name")]
        public void getName_givenTwoValues_returnContainIgnoringCase()
        {
            //Arrange
            Names names = new Names();
            //Act
            var result = names.getName("Joao", "Pedro");
            //Assert
            Assert.Contains("joao", result,StringComparison.CurrentCultureIgnoreCase);
        }
    }
}
