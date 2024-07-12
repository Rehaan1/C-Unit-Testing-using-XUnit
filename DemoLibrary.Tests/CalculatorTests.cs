using Xunit;

namespace DemoLibrary.Tests
{

    public class CalculatorTests
    {
        // A Theory is a test that is run with multiple sets of data
        [Theory]
        [InlineData(4, 3, 7)]
        [InlineData(21, 5.25, 26.25)]
        [InlineData(double.MaxValue, 5, double.MaxValue)]
        public void Add_SimpleValuesShouldCalculate(double x, double y, double expected)
        {
            // Act
            double actual = Calculator.Add(x, y); // Value that is actually returned

            // Assert Phase
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8, 4, 4)]
        [InlineData(10, 2.5, 7.5)]
        [InlineData(double.MaxValue, 5, double.MaxValue - 5)]
        public void Subtract_SimpleValuesShouldCalculate(double x, double y, double expected)
        {
            // Act
            double actual = Calculator.Subtract(x, y);

            // Assert Phase
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4, 2, 8)]
        [InlineData(3, 3, 9)]
        [InlineData(2, 2, 4)]
        public void Multiply_SimpleValuesShouldCalculate(double x, double y, double expected)
        {
            // Act
            double actual = Calculator.Multiply(x, y);

            // Assert Phase
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8, 2, 4)]
        [InlineData(10, 2, 5)]
        [InlineData(100, 4, 25)]
        public void Divide_SimpleValuesShouldCalculate(double x, double y, double expected)
        {
            // Act
            double actual = Calculator.Divide(x, y);

            // Assert Phase
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Divide_DivideByZeroShouldReturnZero()
        {
            // Arrange
            double expected = 0;

            // Act
            double actual = Calculator.Divide(15, 0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
