namespace LeetCodeTraining.PalindromeNumber9;

//https://leetcode.com/problems/palindrome-number/
public static class PalidnromeNumberSolution
{
    public static bool IsPalindrome(int x)
    {
        char[] reversed = x.ToString().ToCharArray();
        Array.Reverse(reversed);

        return x.ToString() == new string(reversed);
    }
}
