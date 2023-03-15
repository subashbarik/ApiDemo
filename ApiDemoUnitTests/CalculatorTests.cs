using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Business;

namespace ApiDemoUnitTests
{
    public class CalculatorTests
    {
        [Fact]
        public void CalculatorTests_add_should_pass()
        {
            //Arrange
            int i = 2; int j = 3; int k = 5;
            var calculator = new Calculator();

            //Act
            var result = calculator.add(i, j);

            //Assert
            Assert.Equal(k, result);

        }
    }
}
