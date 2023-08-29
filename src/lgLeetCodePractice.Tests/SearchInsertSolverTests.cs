using Moq;
using System;
using Xunit;
using lgLeetCodePractice;
using FluentAssertions;

namespace lgLeetCodePractice.Tests
{
    public class SearchInsertSolverTests
    {
        private MockRepository mockRepository;

        private SearchInsertSolver CreateSearchInsertSolver()
        {
            return new SearchInsertSolver();
        }

        [Theory]
        [InlineData(new int[] { 1, 3, 5, 6 }, 5, 2)]
        [InlineData(new int[] { 1, 3, 5, 6 }, 2, 1)]
        [InlineData(new int[] { 1, 3, 5, 6 }, 6, 3)]
        [InlineData(new int[] { 1, 3, 5, 7 }, 7, 3)]
        [InlineData(new int[] { 1, 3, 5, 6 }, 7, 4)]
        [InlineData(new int[] {2, 3, 5, 6 }, 1, 0)]
        public void SearchInsert(int[] nums, int target, int expected)
        {
            // Arrange
            var searchInsertSolver = this.CreateSearchInsertSolver();

            // Act
            var result = searchInsertSolver.SearchInsert(nums, target);

            // Assert
            result.Should().Be(expected);
        }
    }
}
