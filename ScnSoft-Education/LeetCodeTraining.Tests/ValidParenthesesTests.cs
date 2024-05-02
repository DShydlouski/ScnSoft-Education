using LeetCodeTraining.ValidParentheses;
namespace LeetCodeTraining.Tests
{
    public class ValidParenthesesTests
    {
        [Theory]
        [InlineData("()", true)]
        [InlineData("()[]{}", true)]
        [InlineData("(]", false)]
        [InlineData("([)]", false)]
        [InlineData("{[]}", true)]
        public void IsValidTests(string input, bool expected)
        {
            //Act
            bool result = ValidParenthesesSolution.IsValid(input);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}