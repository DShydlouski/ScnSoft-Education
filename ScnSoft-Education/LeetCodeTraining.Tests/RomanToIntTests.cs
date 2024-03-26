using LeetCodeTraining.RomanToInt;

namespace LeetCodeTraining.Tests
{
    public class RomanToIntTests
    {
        [Theory]
        [InlineData("III", 3)]
        [InlineData("LVIII", 58)]
        [InlineData("MCMXCIV", 1994)]
        public void RomanToIntSolutionTests(string input, int expected)
        {
            //Arange
            int result = RomanToIntSolution.RomanToInt(input);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}