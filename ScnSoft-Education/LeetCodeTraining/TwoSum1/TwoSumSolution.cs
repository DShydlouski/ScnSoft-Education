namespace LeetCodeTraining.TwoSum1;

//https://leetcode.com/problems/two-sum/
public static class TwoSumSolution
{
    public static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> indexNum = new();
        for (int i = 0; i < nums.Length; i++)
        {
            var compliment = target - nums[i];
            if (indexNum.ContainsKey(compliment))
            {
                return new int[] { i, indexNum[compliment] };
            }
            indexNum[nums[i]] = i;
        }
        return null;
    }
}

