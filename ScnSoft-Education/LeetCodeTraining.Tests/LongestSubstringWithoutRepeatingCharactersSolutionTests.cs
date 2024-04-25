using LeetCodeTraining.LongestSubstringWithoutRepeatingCharacters;

namespace LeetCodeTraining.Tests
{
    public class LongestSubstringWithoutRepeatingCharactersSolutionTests
    {
        [Theory]
        [InlineData("abcabcbb",3)]
        [InlineData("bbbbb", 1)]
        [InlineData("pwwkew", 3)]
        public void LengthOfLongestSubstringSolutionTests(string input, int expected)
        {
            //Arrange
            int result = LongestSubstringWithoutRepeatingCharactersSolution.LengthOfLongestSubstring(input);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}