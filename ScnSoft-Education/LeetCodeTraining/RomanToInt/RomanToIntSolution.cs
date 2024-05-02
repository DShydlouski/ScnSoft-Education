namespace LeetCodeTraining.RomanToInt
{
    public static class RomanToIntSolution
    {
        public static int RomanToInt(string s)
        {
            Dictionary<char, int> match = new Dictionary<char, int>()
        {
            {'M', 1000 },
            {'D', 500 },
            {'C', 100 },
            {'L', 50 },
            {'X', 10 },
            {'V', 5 },
            {'I', 1 }
        };

            int buff = 0;
            int result = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (match[s[i]] >= buff) result += match[s[i]];
                else result -= match[s[i]];
                buff = match[s[i]];
            }
            return result;
        }
    }
}
