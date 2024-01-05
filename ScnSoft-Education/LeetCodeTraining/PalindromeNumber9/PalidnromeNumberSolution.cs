
namespace LeetCodeTraining.PalindromeNumber9;

public static class PalidnromeNumberSolution
{
    public static bool IsPalindrome(int x)
    {
        char[] reversed = x.ToString().ToCharArray();
        Array.Reverse(reversed);
        return x.ToString() == new string(reversed);
    }
}
