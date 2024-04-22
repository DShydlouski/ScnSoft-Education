using LeetCodeTraining.MergeTwoSortedLists;

namespace LeetCodeTraining.Tests
{
    public class MergeTwoListsTests
    {
        [Fact]
        public void MergeTwoListsTest_WithTwoFilledLists()
        {
            //Arange
            ListNode list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
            ListNode list2 = new ListNode(1, new ListNode(3, new ListNode(4)));
            ListNode expected = new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(4))))));

            //Act
            ListNode result = MergeTwoSortedListsSolution.MergeTwoLists(list1, list2);

            //Assert
            Assert.Equal(expected.val, result.val);
            Assert.Equal(expected.next.val, result.next.val);
            Assert.Equal(expected.next.next.val, result.next.next.val);
            Assert.Equal(expected.next.next.next.val, result.next.next.next.val);
            Assert.Equal(expected.next.next.next.next.val, result.next.next.next.next.val);
            Assert.Equal(expected.next.next.next.next.next.val, result.next.next.next.next.next.val);
        }
        [Fact]
        public void MergeTwoListsTest_WithOneFilledLists()
        {
            //Arange
            ListNode list1 = new ListNode();
            ListNode list2 = new ListNode(0);
            ListNode expected = new ListNode(0);

            //Act
            ListNode result = MergeTwoSortedListsSolution.MergeTwoLists(list1, list2);

            //Assert
            Assert.Equal(expected.val, result.val);
        }
        [Fact]
        public void MergeTwoListsTest_WithTwoEmptyLists()
        {
            //Arange
            ListNode list1 = new ListNode();
            ListNode list2 = new ListNode();
            ListNode expected = new ListNode();

            //Act
            ListNode result = MergeTwoSortedListsSolution.MergeTwoLists(list1, list2);

            //Assert
            Assert.Equal(expected.val, result.val);
        }
    }
}