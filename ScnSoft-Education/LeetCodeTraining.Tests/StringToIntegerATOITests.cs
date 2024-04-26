using LeetCodeTraining.StringToIntegerATOI;

namespace LeetCodeTraining.Tests
{
    public class StringToIntegerATOITests
    {
        [Theory]
        [InlineData("42",42)]
        [InlineData("   -42", -42)]
        [InlineData("4193 with words", 4193)]
        public void StringToIntTests(string input, int expected)
        {
            //Arange
            int result = StringToIntegerAtoiSolution.MyAtoi(input);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}