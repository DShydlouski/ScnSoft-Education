using LeetCodeTraining.TwoSum1;

namespace LeetCodeTraining.Tests
{
    public class TwoSumSolutionTests
    {
        [Fact]
        public void TwoSum_ArrayWith2Nums()
        {
            //Arrange
            int[] nums = { 3, 3 };
            int target = 6;
            int[] expectedResult = { 0, 1 };
            //Act
            int[] result = TwoSumSolution.TwoSum(nums, target);
            //Assert
            Assert.Equal(expectedResult.Length, result.Length);
            Array.Sort(expectedResult);
            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }
    }
}