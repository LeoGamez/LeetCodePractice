using Moq;
using System;
using Xunit;
using lgLeetCodePractice;
using FluentAssertions;

namespace lgLeetCodePractice.Tests
{
    public class LengthOfSubstringSolverTests
    {

        [Theory]
        [InlineData(null, 0)]
        [InlineData("a", 1)]
        [InlineData("ab", 2)]
        [InlineData("abc", 3)]
        [InlineData("dabc", 4)]
        [InlineData("dvdf", 3)]
        [InlineData("abcabcbb", 3)]
        [InlineData("bbbb", 1)]
        [InlineData("", 0)]
        [InlineData("abbbba", 2)]
        [InlineData("aaaabcdaaa", 4)]
        [InlineData("aabcdaaa", 4)]
        [InlineData("bcdaaae", 4)]
        [InlineData("bacdeaaabcdaaa", 5)]
        [InlineData("pwwkew", 3)]
        [InlineData("apapwpwwkewx", 4)]
        public void LengthOfLongestSubstring(string s, int expected)
        {
            // Arrange
            var solver = new LengthOfSubstringSolver();

            // Act
            var result = solver.LengthOfLongestSubstring(s);

            // Assert
            result.Should().Be(expected);   
        }
    }
}
