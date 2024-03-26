namespace LeetCodeTraining.ReverseInteger
{
    public static class ReverseIntegerSolution
    {
        public static int Reverse(int x)
        {
            int result = 0;

            while (x != 0)
            {
                int n = x % 10;
                int buff = result * 10 + n;

                if ((buff - n) / 10 != result)
                {
                    return 0;
                }

                result = buff;
                x /= 10;
            }

            return result;
        }
    }
}
