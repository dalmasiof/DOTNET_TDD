using Calculations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CalculationsTest
{
    public class CostumerTest
    {
        [Fact]
        [Trait("Category", "Costumer")]
        public void Customer_name_notEmpty()
        {
            //Arrange
            Costumer costumer = new Costumer();
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
            Costumer costumer = new Costumer();
            //Act

            //Assert
            Assert.InRange(costumer.Age, 25,45);
        }

        [Fact]
        [Trait("Category", "Costumer")]
        public void Customer_UpdateCostume()
        {
            //Arrange
            Costumer costumer = new Costumer();
            //Act

            //Assert
            Assert.Throws<NotImplementedException>(()=>costumer.UpdateConsumer());
        }

        [Fact]
        [Trait("Category", "Costumer")]
        public void Customer_CreateNewCostume()
        {
            //Arrange
            Costumer costumer = new Costumer();
            //Act
            var result = costumer.NewConsumer();
            //Assert
            Assert.IsType(typeof(Costumer),result);
        }
    }
}
