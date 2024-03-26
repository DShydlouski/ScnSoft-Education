using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTraining.ZigZagConversion
{
    public static class ZigZagSolution
    {
        public static string Convert(string s, int numRows)
        {
            if (numRows == 1)
            {
                return s;
            }

            string result = "";

            int interval = numRows * 2 - 2;

            for (int i = 0; i < numRows; ++i)
            {
                int step = 2 * i;

                for (int j = i; j < s.Length; j += step)
                {
                    result += s[j];

                    if (step != interval)
                    {
                        step = interval - step;
                    }
                }
            }

            return result;
        }
    }
}
