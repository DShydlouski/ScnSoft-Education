using System.Text;

namespace LeetCodeTraining.IntToRoman
{
    public static class IntToRomanSolution
    {
        public static string IntToRoman(int num)
        {
            int[] arab = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] roman = new[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

            StringBuilder romanValue = new StringBuilder();
            for (int i = 0; i < 13 && num > 0;)
            {
                if (num >= arab[i])
                {
                    romanValue.Append(roman[i]);
                    num -= arab[i];
                }
                else
                {
                    i++;
                }
            }

            return romanValue.ToString();
        }
    }
}
