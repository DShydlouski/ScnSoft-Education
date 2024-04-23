using LeetCodeTraining.AddTwoNumbers;

namespace LeetCodeTraining.Tests
{
    public class AddTwoNumsTests
    {
        [Fact]
        public void AddTwoNumbersSolutionTests_Expected_708()
        {
            ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
            ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4)));
            ListNode result = AddTwoNumbersSolution.AddTwoNumbers(l1, l2);
            ListNode expected = new ListNode(7, new ListNode(0, new ListNode(8)));

            Assert.Equal([expected.val,
                expected.next.val,
                expected.next.next.val], 
                [result.val, 
                result.next.val, 
                result.next.next.val]);
        }

        [Fact]
        public void AddTwoNumbersSolutionTests_Expected_0()
        {
            ListNode l1 = new ListNode(0);
            ListNode l2 = new ListNode(0);
            ListNode result = AddTwoNumbersSolution.AddTwoNumbers(l1, l2);
            ListNode expected = new ListNode(0);
     
            Assert.Equal([expected.val], [result.val]);
        }

        [Fact]
        public void AddTwoNumbersSolutionTests_Expected_89990001()
        {
            ListNode l1 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))))));
            ListNode l2 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))));
            ListNode result = AddTwoNumbersSolution.AddTwoNumbers(l1, l2);
            ListNode expected = new ListNode(8, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(0, new ListNode(0, new ListNode(0, new ListNode(1))))))));

            Assert.Equal(
                [expected.val, 
                expected.next.val, 
                expected.next.next.val, 
                expected.next.next.next.val, 
                expected.next.next.next.next.val, 
                expected.next.next.next.next.next.val, 
                expected.next.next.next.next.next.next.val, 
                expected.next.next.next.next.next.next.next.val], 
                [result.val,
                result.next.val,
                result.next.next.val,
                result.next.next.next.val,
                result.next.next.next.next.val,
                result.next.next.next.next.next.val,
                result.next.next.next.next.next.next.val,
                result.next.next.next.next.next.next.next.val]);
        }
    }
}