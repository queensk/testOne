using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sendMessage.Calculator;
using Moq;

namespace tests
{
    [TestFixture]
    public class CalculatorServiceTests
    {
        private Mock<ILoggerService> _mockLoggerService;
        private CalculatorService _calculatorService;

        [SetUp]
        public void SetUp()
        {
            _mockLoggerService = new Mock<ILoggerService>();
            _calculatorService = new CalculatorService(_mockLoggerService.Object);
        }

        [Test]
        public void Add_InputTwoNumbers_ReturnSumAndLogMessages()
        {
            // Arrange
            int x = 2;
            int y = 3;
            _mockLoggerService.Setup(ls => ls.Log(It.IsAny<string>()));

            // Act
            int result = _calculatorService.Add(x, y);

            // Assert
            // Check if the result is equal to 5
            Assert.That(result, Is.EqualTo(5));
            // Verify that the mock object's Log method was called twice with the expected messages and order
            _mockLoggerService.Verify(ls => ls.Log($"Adding {x} and {y}"), Times.Once);
            _mockLoggerService.Verify(ls => ls.Log($"Result is {result}"), Times.Once);
            _mockLoggerService.VerifyNoOtherCalls();
        }
    }
}