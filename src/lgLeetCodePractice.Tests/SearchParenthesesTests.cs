using System;
using Xunit;
using lgLeetCodePractice;
using FluentAssertions;

namespace lgLeetCodePractice.Tests
{
    public class SearchParenthesesTests
    {
        [Theory]
        [InlineData("()",true)]
        [InlineData("(}",false)]
        [InlineData("()[]{}",true)]
        [InlineData("([])",true)]
        [InlineData("([)",false)]
        [InlineData("([{)",false)]
        [InlineData(")[",false)]
        [InlineData("([]){",false)]
        public void SearchParentheses_WithResult(string s, bool result)
        {
            // Arrange
            var searchParentheses = new SearchParentheses();

            // Act
            var isValid=searchParentheses.IsValid(s);

            // Assert
            result.Should().Be(isValid);
        }

        [Theory]
        [InlineData("()", true)]
        [InlineData("(}", false)]
        [InlineData("()[]{}", true)]
        [InlineData("([])", true)]
        [InlineData("([)", false)]
        [InlineData("([{)", false)]
        [InlineData(")[", false)]
        [InlineData("([]){", false)]
        [InlineData("([)]", false)]
        [InlineData(@"([{)]}", false)]
        [InlineData(@"([{)}]", false)]
        [InlineData("([{}])", true)]
        [InlineData("}([{}]){", false)]
        [InlineData("()[]([{}]){}", true)]

        public void SearchParentheses_WithResultB(string s, bool result)
        {
            // Arrange
            var searchParentheses = new SearchParentheses();

            // Act
            var isValid = searchParentheses.IsValidB(s);

            // Assert
            result.Should().Be(isValid);
        }
    }
}
