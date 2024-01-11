namespace LeetCodeTraining.LongestPalindromicSubstring5;

public static class LongestPalindromicSubstringSolution
{
    public static bool IsPalindrome(string x)
    {
        char[] reversed = x.ToString().ToCharArray();
        Array.Reverse(reversed);
        return x.ToString() == new string(reversed);
    }
    public static string LongestPalindrome(string s)
    {
        int end = s.Length;
        string result = "";
        string buff = "";
        int counter = 0;

        for (int i = s.Length; i > 0; i--)
        {
            buff = s.Substring(counter, i);

            if (IsPalindrome(buff))
            {
                result = buff;
                break;
            }
            else
            {
                if (counter + i == s.Length)
                {
                    counter = 0;
                }
                else
                {
                    counter++;
                    ++i;
                }
            }
        }

        return result;
    }
}
