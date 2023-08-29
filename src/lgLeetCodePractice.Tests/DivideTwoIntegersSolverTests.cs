using Moq;
using System;
using Xunit;
using lgLeetCodePractice;
using FluentAssertions;

namespace lgLeetCodePractice.Tests
{
    public class DivideTwoIntegersSolverTests
    {
        private MockRepository mockRepository;



        public DivideTwoIntegersSolverTests()
        {


        }

        private DivideTwoIntegersSolver CreateDivideTwoIntegersSolver()
        {
            return new DivideTwoIntegersSolver();
        }

        [Theory]
        [InlineData(0,0,0)]
        [InlineData(0,1,0)]
        [InlineData(1,1,1)]
        [InlineData(1,2,0)]
        [InlineData(3,2,1)]
        [InlineData(4,2,2)]
        [InlineData(6,2,3)]
        [InlineData(100,5,20)]
        [InlineData(101,5,20)]
        [InlineData(105,5,21)]
        [InlineData(104,5,20)]
        [InlineData(2000,110,18)]
        [InlineData(-1,1,-1)]
        [InlineData(2,-1,-2)]
        [InlineData(-25,-5,5)]
        [InlineData(int.MinValue, -1, int.MaxValue)]
        [InlineData(int.MinValue, 1, int.MinValue)]
        public void Divide(int dividend, int divisor, int? expected)
        {
            // Arrange
            var divideTwoIntegersSolver = this.CreateDivideTwoIntegersSolver();

            // Act
            var result = divideTwoIntegersSolver.Divide(
                dividend,
                divisor);

            // Assert
            result.Should().Be(expected);
        }
    }
}
