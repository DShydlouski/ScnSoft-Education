namespace LeetCodeTraining.AddTwoNumbers
{
    public static class AddTwoNumbersSolution
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2, int n = 0)
        {
            if (l1 == null && l2 == null && n == 0)
            {
                return null;
            }

            int amount = (l1 != null ? l1.val : 0) + (l2 != null ? l2.val : 0) + n;
            n = amount / 10;

            return new ListNode(amount % 10, AddTwoNumbers(l1?.next, l2?.next, n));
        }
    }
}
