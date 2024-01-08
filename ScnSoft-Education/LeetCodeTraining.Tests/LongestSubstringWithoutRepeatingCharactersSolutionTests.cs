using LeetCodeTraining.LongestSubstringWithoutRepeatingCharacters;

namespace LeetCodeTraining.Tests
{
    public class LongestSubstringWithoutRepeatingCharactersSolutionTests
    {
        [Theory]
        [InlineData("abcabcbb",3)]
        [InlineData("bbbbb", 1)]
        [InlineData("pwwkew", 3)]
        public void LengthOfLongestSubstringSolutionTests(string value1, int value2)
        {
            //Arrange
            int result = LongestSubstringWithoutRepeatingCharactersSolution.LengthOfLongestSubstring(value1);


            //Assert
            Assert.Equal(value2, result);
        }
    }
}