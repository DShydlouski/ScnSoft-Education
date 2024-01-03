using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTraining.TwoSum1
{
    //https://leetcode.com/problems/two-sum/
    public static class TwoSumSolution
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            if (nums == null || nums.Length < 2) return null;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target) return new int[] { i, j };
                }
            }
            return new int[] { };
        }
    }
}
