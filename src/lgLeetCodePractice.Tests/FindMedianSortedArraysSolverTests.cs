using Moq;
using System;
using Xunit;
using lgLeetCodePractice;
using FluentAssertions;

namespace lgLeetCodePractice.Tests
{
    public class FindMedianSortedArraysSolverTests
    {
        private FindMedianSortedArraysSolver CreateFindMedianSortedArraysSolver()
        {
            return new FindMedianSortedArraysSolver();
        }

        [Theory]
        [InlineData(null,null,0)]
        [InlineData(new int[] {},new int[] { },0)]
        [InlineData(new int[] {1},new int[] { },1)]
        [InlineData(new int[] {},new int[] { 1},1)]
        [InlineData(new int[] {1},new int[] { 1},1)]
        [InlineData(new int[] {0},new int[] {1},0.5)]
        [InlineData(new int[] {1},new int[] {2,3},2)]
        [InlineData(new int[] {1,4},new int[] {2,3},2.5)]
        [InlineData(new int[] {3,5,7},new int[] {8,6},6)]
        [InlineData(new int[] {1,2},new int[] {3,7},2.5)]
        [InlineData(new int[] {1},new int[] {1,2},1)]
        [InlineData(new int[] {1,2,2,2},new int[] {1,3,2},2)]
        public void FindMedianSortedArrays(int[] nums1, int[] nums2, double expected)
        {
            // Arrange
            var findMedianSortedArraysSolver = this.CreateFindMedianSortedArraysSolver();

            // Act
            var result = findMedianSortedArraysSolver.FindMedianSortedArrays(
                nums1,
                nums2);

            // Assert
            result.Should().Be(expected);
        }
    }
}
