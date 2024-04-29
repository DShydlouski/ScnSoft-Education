using LeetCodeTraining.ContainerWithMostWater;

namespace LeetCodeTraining.Tests
{
    public class ContainerWithMostWaterTests
    {
        [Theory]
        [InlineData((int[])[1, 8, 6, 2, 5, 4, 8, 3, 7],49)]
        [InlineData((int[])[1, 1],1)]
        public void MaxAreaMethodTest(int[] input, int expected)
        {
            //Arange
            int result = ContainerWithMostWaterSolution.MaxArea(input);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}