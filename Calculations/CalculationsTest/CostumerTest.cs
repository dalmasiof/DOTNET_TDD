using Calculations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CalculationsTest
{
    public class CostumerFixture
    {
        public Costumer Costumer => new Costumer();
    }
    public class CostumerTest:IClassFixture<CostumerFixture>
    {
        private readonly CostumerFixture _fixture;
        public CostumerTest(CostumerFixture fixture)
        {
            _fixture = fixture;
        }
        [Fact]
        [Trait("Category", "Costumer")]
        public void Customer_name_notEmpty()
        {
            //Arrange
            var costumer = _fixture.Costumer;
            //Act

            //Assert
            Assert.NotEmpty(costumer.Name);
            Assert.False(string.IsNullOrEmpty(costumer.Name));
        }
        [Fact]
        [Trait("Category","Costumer")]
        public void Customer_AgeBetween_25and45()
        {
            //Arrange
            var costumer = _fixture.Costumer;  
            //Act

            //Assert
            Assert.InRange(costumer.Age, 25,45);
        }

        [Fact]
        [Trait("Category", "Costumer")]
        public void Customer_UpdateCostume()
        {
            //Arrange
            var costumer = _fixture.Costumer;
            //Act

            //Assert
            Assert.Throws<NotImplementedException>(()=>costumer.UpdateConsumer());
        }

        [Fact]
        [Trait("Category", "Costumer")]
        public void Customer_CreateNewCostume()
        {
            //Arrange
            var costumer = _fixture.Costumer;
            //Act
            var result = costumer.NewConsumer();
            //Assert
            Assert.IsType(typeof(Costumer),result);
        }
    }
}
