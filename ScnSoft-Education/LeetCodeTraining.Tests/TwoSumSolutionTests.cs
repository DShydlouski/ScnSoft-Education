using LeetCodeTraining.TwoSum1;

namespace LeetCodeTraining.Tests
{
    public class TwoSumSolutionTests
    {
        [Theory]
        [InlineData((int[])[3, 3], 6, (int[])[1,0])]
        [InlineData((int[])[2, 7, 11, 15], 9, (int[])[1, 0])]
        [InlineData((int[])[3, 2, 4], 6, (int[])[2, 1])]
        public void TwoSumTests(int[] nums, int target, int[] expected)
        {          
            //Act
            int[] result = TwoSumSolution.TwoSum(nums, target);

            //Assert          
            Assert.Equal(expected, result);
        }
    }
}