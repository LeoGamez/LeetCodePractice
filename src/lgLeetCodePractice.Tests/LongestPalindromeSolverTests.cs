using Moq;
using System;
using Xunit;
using lgLeetCodePractice;
using FluentAssertions;

namespace lgLeetCodePractice.Tests
{
    public class LongestPalindromeSolverTests
    {
        private LongestPalindromeSolver CreateLongestPalindromeSolver()
        {
            return new LongestPalindromeSolver();
        }

        [Theory]
        [InlineData(null,null)]
        [InlineData("","")]
        [InlineData("a","a")]
        [InlineData("aa","aa")]
        [InlineData("aba","aba")]
        [InlineData("abac","aba")]
        [InlineData("cabad","aba")]
        [InlineData("cabac","cabac")]
        [InlineData("hcabac","cabac")]
        [InlineData("xxcabacy","cabac")]
        [InlineData("xcabacyyx","cabac")]
        [InlineData("testxweewyyy", "weew")]
        public void LongestPalindrome(string s, string? expected)
        {
            // Arrange
            var longestPalindromeSolver = this.CreateLongestPalindromeSolver();

            // Act
            var result = longestPalindromeSolver.LongestPalindrome(s);

            // Assert
            result.Should().Be(expected);
        }
    }
}
