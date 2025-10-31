```csharp
using Xunit;
using AgentTest;
using System;

namespace AgentTest.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_ShouldReturnCorrectSum()
        {
            // Arrange
            var calculator = new Calculator();
            int a = 5;
            int b = 3;
            int expected = 8;

            // Act
            int actual = calculator.Add(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Subtract_ShouldReturnCorrectDifference()
        {
            // Arrange
            var calculator = new Calculator();
            int a = 5;
            int b = 3;
            int expected = 2;

            // Act
            int actual = calculator.Subtract(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Multiply_ShouldReturnCorrectProduct()
        {
            // Arrange
            var calculator = new Calculator();
            int a = 5;
            int b = 3;
            int expected = 15;

            // Act
            int actual = calculator.Multiply(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Divide_ShouldReturnCorrectQuotient()
        {
            // Arrange
            var calculator = new Calculator();
            int a = 15;
            int b = 3;
            int expected = 5;

            // Act
            int actual = calculator.Divide(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Divide_ShouldThrowDivideByZeroException_WhenDividingByZero()
        {
            // Arrange
            var calculator = new Calculator();
            int a = 15;
            int b = 0;

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(a, b));
        }
    }
}
```