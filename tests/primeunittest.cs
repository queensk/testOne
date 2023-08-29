using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using PrimeService.Function;

namespace tests
{
    public class primeUniTest
    {
         private PrimeServiceFunction _primeService;

        [SetUp]
        public void SetUp()
        {
            _primeService = new PrimeServiceFunction();
        }

        [Test]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            // Arrange
            int input = 1;

            // Act
            bool result = _primeService.IsPrime(input);

            // Assert
            Assert.IsFalse(result, "1 should not be prime");
        }
    }
}