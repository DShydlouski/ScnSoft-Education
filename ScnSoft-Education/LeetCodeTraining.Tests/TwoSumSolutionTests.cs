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
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void TwoSum_ArrayWith4Nums()
        {
            //Arrange
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            int[] expectedResult = { 0, 1 };

            //Act
            int[] result = TwoSumSolution.TwoSum(nums, target);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void TwoSum_ArrayWith3Nums()
        {
            //Arrange
            int[] nums = { 3, 2, 4 };
            int target = 6;
            int[] expectedResult = { 1, 2 };

            //Act
            int[] result = TwoSumSolution.TwoSum(nums, target);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}