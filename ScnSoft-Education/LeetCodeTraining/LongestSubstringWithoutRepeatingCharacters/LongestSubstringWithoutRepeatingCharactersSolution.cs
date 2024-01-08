namespace LeetCodeTraining.LongestSubstringWithoutRepeatingCharacters
{
    //https://leetcode.com/problems/longest-substring-without-repeating-characters/
    public static class LongestSubstringWithoutRepeatingCharactersSolution
    {
        public static int LengthOfLongestSubstring(string s)
        {
            string buff = "";
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                var pos = buff.IndexOf(s[i]);
                if (pos != -1)
                {
                    i = i - (buff.Length - pos);
                    if (count < buff.Length)
                    {
                        count = buff.Length;
                    }
                    buff = "";
                }
                else
                {
                    buff += s[i];
                }
            }
            if (count < buff.Length)
            {
                count = buff.Length;
            }
            return count;
        }
    }
}
