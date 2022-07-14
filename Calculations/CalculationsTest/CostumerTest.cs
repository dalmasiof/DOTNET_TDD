﻿using Calculations;
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
        public void Customer_AgeBetween_25and45()
        {
            //Arrange
            Costumer costumer = new Costumer();
            //Act

            //Assert
            Assert.InRange(costumer.Age, 25,45);
        }
    }
}
