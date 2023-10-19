using Moq;
using System;
using Xunit;
using lgLeetCodePractice;
using FluentAssertions;

namespace lgLeetCodePractice.Tests
{
    public class RemoveDuplicatesSolverTests
    {

        private RemoveDuplicatesSolver CreateRemoveDuplicatesSolver()
        {
            return new RemoveDuplicatesSolver();
        }

        [Theory]
        [InlineData(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, 5)]
        [InlineData(new int[] { 1,1,2 }, 2)]
        public void RemoveDuplicates(int[] nums, int expected)
        {
            // Arrange
            var removeDuplicatesSolver = this.CreateRemoveDuplicatesSolver();

            // Act
            var result = removeDuplicatesSolver.RemoveDuplicates(ref nums);

            // Assert
            result.Should().Be(expected);
        }
    }
}
