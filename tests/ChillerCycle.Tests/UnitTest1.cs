using Xunit;
using ChillerCycle.Module;
using System;

namespace ChillerCycle.Tests
{
    public class ChillerCycleCalculatorTests
    {
        [Fact]
        public void CalculateCOP_ValidInputs_ReturnsCorrectQuotient()
        {
            double result = ChillerCycleCalculator.CalculateCOP(100, 25);
            Assert.Equal(4.0, result, 3);
        }

        [Fact]
        public void CalculateCOP_ZeroWork_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() =>
                ChillerCycleCalculator.CalculateCOP(100, 0));
        }

        [Fact]
        public void CalculateCOP_NegativeHeat_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() =>
                ChillerCycleCalculator.CalculateCOP(-5, 10));
        }

        [Fact]
        public void CalculateCOP_NegativeWork_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() =>
                ChillerCycleCalculator.CalculateCOP(-10, 0));
        }

        [Fact]
        public void CalculateCOP_NegativeEvap_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() =>
                ChillerCycleCalculator.CalculateIdealCOP(-300, 50));
        }

        [Fact]
        public void CalculateCOP_NegativeCond_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() =>
                ChillerCycleCalculator.CalculateIdealCOP(10, -50));
        }
    }
}
