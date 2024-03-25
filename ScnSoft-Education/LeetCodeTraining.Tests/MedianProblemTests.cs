using LeetCodeTraining.MedianOfTwoSortedArrays;

namespace LeetCodeTraining.Tests
{
    public class MedianProblemTests
    {
        [Theory]
        [InlineData((int[])[1, 3], (int[])[2], 2)]
        [InlineData((int[])[1, 2], (int[])[3, 4], 2.5)]
        public void MedianProblemSolutionTest(int[] num1, int[] num2, double expected)
        {
            //Arange
            double result = MedianOfTwoSortedArraysSolution.FindMedianSortedArrays(num1, num2);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}