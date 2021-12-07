using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RetailCalculatorLibrary;
using Xunit;

namespace UnitTestingLibrary.Test
{
    public class CalculatorTests
    {
        [Fact]
        public void Calculate_SimpleValues()
        {
            // Arrange
            double expected = 15022.50;

            // Act
            double actual = Calculate.CalculateRetail(15000.00, 0.15);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
