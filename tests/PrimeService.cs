using NUnit.Framework;
using PrimeService.Function;

namespace PrimeService.Tests
{
    public class PrimeServiceTests
    {
        private PrimeServiceFunction _primeService;

        [SetUp]
        public void Setup()
        {
            _primeService = new PrimeServiceFunction();
        }

        [Test]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            var result = _primeService.IsPrime(1);

            Assert.False(result, "1 should not be prime");
        }
        
        [Test]
        [TestCase(-1, false)]
        [TestCase(0, false)]
        [TestCase(1, false)]
        [TestCase(2, true)]
        [TestCase(3, true)]
        [TestCase(4, false)]
        [TestCase(5, true)]
        public void IsPrime_ValuesLessThan10_ReturnTrueOrFalse(int value, bool expected)
        {
            var result = _primeService.IsPrime(value);

            Assert.That(result, Is.EqualTo(expected), $"{value} should be {expected}");
        }

    }
}
