using Moq;
using System;
using Xunit;
using lgLeetCodePractice;
using FluentAssertions;

namespace lgLeetCodePractice.Tests
{
    public class RomanToIntSolverTests
    {
        private RomanToIntSolver CreateRomanToIntSolver()
        {
            return new RomanToIntSolver();
        }

        [Theory]
        [InlineData("",0)]
        [InlineData("III",3)]
        [InlineData("IV",4)]
        [InlineData("V",5)]
        [InlineData("VI",6)]
        [InlineData("LVIII", 58)]
        [InlineData("MCMXCIV", 1994)]
        [InlineData("MMMCMXCIX", 3999)]
        [InlineData("MMMCDXLIV", 3444)]
        [InlineData("DLV", 555)]
        [InlineData("MMDCCCLXXXVIII", 2888)]
        public void RomanToInt(string s, int expected)
        {
            // Arrange
            var romanToIntSolver = this.CreateRomanToIntSolver();

            // Act
            var result = romanToIntSolver.RomanToInt(s);

            // Assert
            result.Should().Be(expected);
        }
    }
}
