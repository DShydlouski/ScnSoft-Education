namespace LeetCodeTraining.StringToIntegerATOI
{
    public static class StringToIntegerAtoiSolution
    {
        public static int MyAtoi(string s)
        {
            bool isNegative = false;
            bool hasStarted = false;
            int result = 0;

            foreach (char c in s)
            {
                if (c == ' ')
                {
                    if (hasStarted)
                    {
                        break;
                    }
                    continue;
                }

                if (char.IsDigit(c))
                {
                    int digit = c - '0';

                    if (result > int.MaxValue / 10 || (result == int.MaxValue / 10 && digit > 7))
                    {
                        if (isNegative)
                        {
                            return int.MinValue;
                        }
                        else
                        {
                            return int.MaxValue;
                        }
                    }

                    result = result * 10 + digit;
                    hasStarted = true;
                }
                else if (hasStarted)
                {
                    break;
                }
                else if (c == '-')
                {
                    isNegative = true;
                    hasStarted = true;
                }
                else if (c == '+')
                {
                    hasStarted = true;
                }
                else
                {
                    break;
                }
            }

            if (isNegative)
            {
                result *= -1;
            }

            return result;
        }
    }
}
