using FluentAssertions;
using NUnit.Framework;

namespace Combinations
{
    public class CalculatorTests : TestBase
    {
        [Test]
        public void Two_Factorial_Should_Equal_2()
        {
            var result = Calculator.Factorial(2);
            const int expected = 2;
            result.Should().Be(expected);
        }

        [Test]
        public void Three_Factorial_Should_Equal_6()
        {
            var result = Calculator.Factorial(3);
            const int expected = 6;
            result.Should().Be(expected);
        }

        [Test]
        public void Four_Factorial_Should_Equal_12()
        {
            var result = Calculator.Factorial(4);
            const int expected = 24;
            result.Should().Be(expected);
        }

        [Test]
        public void Five_Factorial_Should_Equal_120()
        {
            var result = Calculator.Factorial(5);
            const int expected = 120;
            result.Should().Be(expected);
        }
    }
}