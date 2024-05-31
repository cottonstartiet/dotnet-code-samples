using NUnit.Framework;

namespace CodingWithCopilotTests
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

        [Test]
        public void Add_ShouldReturnCorrectSum()
        {
            // Arrange
            int num1 = 5;
            int num2 = 10;

            // Act
            int result = calculator.Add(num1, num2);

            // Assert
            Assert.That(result, Is.EqualTo(15));
        }

        [Test]
        public void Add_ShouldHandleNegativeNumbers()
        {
            // Arrange
            int num1 = -5;
            int num2 = -10;

            // Act
            int result = calculator.Add(num1, num2);

            // Assert
            Assert.That(result, Is.EqualTo(-15));
        }

        [Test]
        public void Add_ShouldHandleOverflow()
        {
            // Arrange
            int num1 = int.MaxValue;
            int num2 = 1;

            // Act
            int result = calculator.Add(num1, num2);

            // Assert
            Assert.That(result, Is.EqualTo(int.MinValue));
        }
    }
}
