using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTraining.MedianOfTwoSortedArrays
{
    public static class MedianOfTwoSortedArraysSolution
    {
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            if (nums1 == null && nums2 == null)
            {
                return 0D;
            }

            int x = nums1.Length;
            int y = nums2.Length;
            int[] buffResult = new int[x + y];
            double result = 0;

            bool isEven = (x + y) % 2 == 0;
            int middle = (x + y) / 2;

            Array.Copy(nums1, 0, buffResult, 0, x);
            Array.Copy(nums2, 0, buffResult, x, y);
            Array.Sort(buffResult);

            if (isEven)
            {
                result = (buffResult[middle - 1] + buffResult[middle]) / 2D;
            }
            else
            {
                result = buffResult[middle];
            }

            return result;
        }
    }
}
