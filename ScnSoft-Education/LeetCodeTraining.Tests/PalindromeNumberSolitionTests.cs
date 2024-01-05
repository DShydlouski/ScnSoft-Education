using LeetCodeTraining.PalindromeNumber9;

namespace LeetCodeTraining.Tests
{
    public class PalindromeNumberSolitionTests
    {
        [Fact]
        public void PalindromeNumber_StringWith3Nums()
        {
            //Arrange
            int x = 121;
            bool expectedResult = true;
            bool result;

            //Act
            result = PalidnromeNumberSolution.IsPalindrome(x);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void PalindromeNumber_StringWithNegativeNums()
        {
            //Arrange
            int x = -121;
            bool expectedResult = false;
            bool result;

            //Act
            result = PalidnromeNumberSolution.IsPalindrome(x);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void PalindromeNumber_StringWith2Nums()
        {
            //Arrange
            int x = 10;
            bool expectedResult = false;
            bool result;

            //Act
            result = PalidnromeNumberSolution.IsPalindrome(x);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
