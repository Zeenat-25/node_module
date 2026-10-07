using CalculatorTesting;

namespace CalculatorTesting.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void AddTest()
        {
            CalculatorService c = new CalculatorService();
            int result = c.Add(10, 20);

            Assert.Equal(30, result);
        }

        [Fact]
        public void SubtractTest()
        {
            CalculatorService c = new CalculatorService();
            int result = c.Subtract(20, 10);

            Assert.Equal(10, result);
        }

        [Fact]
        public void MultiplyTest()
        {
            CalculatorService c = new CalculatorService();
            int result = c.Multiply(5, 4);

            Assert.Equal(20, result);
        }

        [Fact]
        public void DivideTest()
        {
            CalculatorService c = new CalculatorService();
            double result = c.Divide(20, 5);

            Assert.Equal(4, result);
        }

        [Fact]
        public void DivideByZeroTest()
        {
            CalculatorService c = new CalculatorService();

            Assert.Throws<DivideByZeroException>(
                () => c.Divide(10, 0)
            );
        }
    }
}