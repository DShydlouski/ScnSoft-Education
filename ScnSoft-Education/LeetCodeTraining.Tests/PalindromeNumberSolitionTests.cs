using LeetCodeTraining.PalindromeNumber9;

namespace LeetCodeTraining.Tests
{
    public class PalindromeNumberSolitionTests
    {
        [Theory]
        [InlineData(121, true)]
        [InlineData(-121, false)]
        [InlineData(10, false)]
        public void PalindromeNumberTests(int x, bool expectedResult)
        {
            //Arrange
            bool result = PalidnromeNumberSolution.IsPalindrome(x);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
