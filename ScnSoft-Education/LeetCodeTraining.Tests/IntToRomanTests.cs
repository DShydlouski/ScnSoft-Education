using LeetCodeTraining.IntToRoman;

namespace LeetCodeTraining.Tests
{
    public class IntToRomanTests
    {
        [Theory]
        [InlineData(3, "III")]
        [InlineData(58, "LVIII")]
        [InlineData(1994, "MCMXCIV")]
        public void IntToRomanSolutionTests(int input, string expected)
        {
            //Arange
            string result = IntToRomanSolution.IntToRoman(input);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}