using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sendMessage.Calculator;

namespace tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Add_InputTwoNumbers_ReturnSum()
        {
            // Arrange
            CalculatorFunction calculator = new CalculatorFunction();
            int x = 2;
            int y = 3;

            // Act
            int result = calculator.Add(x, y);

            // Assert
            Assert.That(result, Is.EqualTo(5));
        }
    }
}