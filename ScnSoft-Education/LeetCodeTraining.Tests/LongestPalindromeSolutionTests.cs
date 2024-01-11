using LeetCodeTraining.LongestPalindromicSubstring5;
namespace LeetCodeTraining.Tests
{
    public class LongestPalindromeSolutionTests
    {
        [Theory]
        [InlineData("babad", "bab")]
        [InlineData("cbbd", "bb")]
        [InlineData("abbacfcd", "abba")]
        public static void LongestPalindromicSubstringSolutionTests(string s, string expected)
        {
            //Arrange
            string result = LongestPalindromicSubstringSolution.LongestPalindrome(s);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}