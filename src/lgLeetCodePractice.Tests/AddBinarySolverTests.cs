using Moq;
using System;
using Xunit;
using lgLeetCodePractice;
using FluentAssertions;

namespace lgLeetCodePractice.Tests
{
    public class AddBinarySolverTests
    {
        private AddBinarySolver CreateAddBinarySolver()
        {
            return new AddBinarySolver();
        }

        [Theory]
        [InlineData("1","1","10")]
        [InlineData("1","10","11")]
        [InlineData("1","11","100")]
        [InlineData("1010","1011","10101")]
        [InlineData("111","1","1000")]
        public void AddBinary(string a, string b, string expected)
        {
            // Arrange
            var addBinarySolver = this.CreateAddBinarySolver();

            // Act
            var result = addBinarySolver.AddBinary(a, b);

            // Assert
            result.Should().Be(expected);
        }
    }
}
