using Moq;
using System;
using Xunit;
using lgLeetCodePractice;
using FluentAssertions;

namespace lgLeetCodePractice.Tests
{
    public class RemoveElementSolverTests
    {
        private RemoveElementSolver CreateRemoveElementSolver()
        {
            return new RemoveElementSolver();
        }

        [Theory]
        [InlineData(new int[] { 3,2,2,3},3,2,new int[] { 2,2})]
        [InlineData(new int[] { 1,1,2,3},1,2,new int[] { 2,3})]
        public void RemoveElement(int[] nums,int val, int expected, int[] expectedArr)
        {
            // Arrange
            var removeElementSolver = this.CreateRemoveElementSolver();

            // Act
            var result = removeElementSolver.RemoveElement(
                ref nums,
                val);

            // Assert
            result.Should().Be(expected);
            nums.Should().BeEquivalentTo(expectedArr);
        }
    }
}
