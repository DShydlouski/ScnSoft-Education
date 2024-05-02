using LeetCodeTraining.MedianOfTwoSortedArrays;

namespace LeetCodeTraining.Tests
{
    public class MedianProblemTests
    {
        [Theory]
        [InlineData((int[])[1, 3], (int[])[2], 2)]
        [InlineData((int[])[1, 2], (int[])[3, 4], 2.5)]
        [InlineData((int[])[1, 2], (int[])[], 1.5)]
        public void MedianProblemSolutionTest(int[] input1, int[] input2, double expected)
        {
            //Arange
            double result = MedianOfTwoSortedArraysSolution.FindMedianSortedArrays(input1, input2);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}