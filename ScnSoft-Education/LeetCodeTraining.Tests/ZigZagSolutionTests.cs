using LeetCodeTraining.ZigZagConversion;

namespace LeetCodeTraining.Tests
{
    public class ZigZagSolutionTests
    {
        [Theory]
        [InlineData("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR")]
        [InlineData("PAYPALISHIRING", 4, "PINALSIGYAHRPI")]
        [InlineData("A", 1, "A")]

        public void ZigZagSolutionTest(string inputString, int inputInt, string expected)
        {
            //Arange
            string result = ZigZagSolution.Convert(inputString, inputInt);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}