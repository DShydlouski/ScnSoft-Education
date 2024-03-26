using LeetCodeTraining.ReverseInteger;

namespace LeetCodeTraining.Tests
{
    public class ReverseIntegerSolutionTests
    {
        [Theory]
        [InlineData(123,321)]
        [InlineData(-123,-321)]
        [InlineData(120,21)]
        public void ReverseInegerTest(int input, int expected)
        {
            //Arange
            int result = ReverseIntegerSolution.Reverse(input);

            //Asseert
            Assert.Equal(expected, result);
        }
    }
}