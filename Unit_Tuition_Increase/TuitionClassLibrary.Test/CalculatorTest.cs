using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuitionLibrary;
using Xunit;

namespace TuitionClassLibrary.Test
{
    public class CalculatorTest
    {
        [Fact]
        public void Calculate_TuitionIncrease()
        {
            // Arrange
            double expected = 6120.00;

            // Act
            double actual = Calculate.CalculateTuition(6000.00, 0.02, 5);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
