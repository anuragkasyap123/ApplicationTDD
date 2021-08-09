using NUnit.Framework;

namespace OperatingSystemTests
{
    public class CalculatorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(10,10,20)]
        [TestCase("", 10, 10)]
        public void CalculatorAddTest(int num1, int num2, int expectedOp)
        {
            _calculator = new Calculator();
            var output = _calculator.Add(num1, num2);
            Assert.That(expectedOp.Equals(output));
            Assert.Pass();
        }

        private Calculator _calculator;
    }
}