using Moq;
using System;
using Xunit;
using lgLeetCodePractice;
using FluentAssertions;

namespace lgLeetCodePractice.Tests
{
    public class PlusOneSolverTests
    {
        private PlusOneSolver CreatePlusOneSolver()
        {
            return new PlusOneSolver();
        }

        [Theory]
        [InlineData(new int[] {9,9}, new int[] { 1,0, 0 })]
        public void PlusOne(int[] digits, int[] expected)
        {
            // Arrange
            var plusOneSolver = this.CreatePlusOneSolver();

            // Act
            var result = plusOneSolver.PlusOne(digits);

            // Assert
            result.Should().BeEquivalentTo(expected);
        }
    }
}
