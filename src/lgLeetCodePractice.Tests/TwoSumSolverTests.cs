using System;
using Xunit;
using lgLeetCodePractice;
using FluentAssertions;

namespace lgLeetCodePractice.Tests
{
    public class TwoSumSolverTests
    {
        [Theory]
        [InlineData(new int[] { 15, 7, 2, 11 },9, new int[] { 1,2 })]
        [InlineData(new int[] { 3, 2, 4 },6, new int[] { 1,2 })]
        [InlineData(new int[] { 3,1, 3 },6, new int[] { 0,2 })]
        [InlineData(new int[] { 3,-1, 2 },1, new int[] { 1,2 })]
        public void TwoSumResults(int[] nums, int target, int[] expected)
        {
            // Arrange
            var twoSumSolver = new TwoSumSolver();

            // Act
            var result = twoSumSolver.TwoSum(
                nums,
                target);

            // Assert
            result.Should().BeEquivalentTo(expected);
        }
    }
}
