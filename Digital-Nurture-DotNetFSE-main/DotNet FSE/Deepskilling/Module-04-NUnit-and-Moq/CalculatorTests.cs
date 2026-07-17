using NUnit.Framework;
using CalcLibrary;

namespace CalcLibrary.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [TearDown]
        public void Cleanup()
        {
            calculator = null;
        }

        [TestCase(5, 10, 15)]
        [TestCase(2, 3, 5)]
        [TestCase(-1, 1, 0)]
        [TestCase(100, 200, 300)]
        public void Add_Test(int a, int b, int expected)
        {
            int actual = calculator.Add(a, b);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
