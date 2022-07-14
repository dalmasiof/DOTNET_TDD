using Calculations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CalculationsTest
{
    public class NamesFixture
    {
        public Names Names => new Names();
    }

    public class NamesTests : IClassFixture<NamesFixture>
    {
        private readonly NamesFixture _fixture;
        public NamesTests(NamesFixture fixture)
        {
            _fixture = fixture;
        }
        [Fact]
        [Trait("Category", "Name")]
        public void getName_givenTwoValues_returnFullName()
        {
            //Arrange
            var names = _fixture.Names;
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
            var names = _fixture.Names;
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
            var names = _fixture.Names;
            //Act
            var result = names.getName("Joao", "Pedro");
            //Assert
            Assert.Contains("joao", result,StringComparison.CurrentCultureIgnoreCase);
        }
    }
}
