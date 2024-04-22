using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTraining.MergeTwoSortedLists
{
    public static class MergeTwoSortedListsSolution
    {
        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null && list2 == null)
            {
                return null;
            }
            if (list1 == null)
            {
                return list2;
            }
            if (list2 == null)
            {
                return list1;
            }

            ListNode buff1;
            ListNode? buff2;

            if (list1.val <= list2.val)
            {
                buff1 = list1;
                buff2 = list2;
            }
            else
            {
                buff1 = list2;
                buff2 = list1;
            }

            ListNode result = buff1;

            while (buff1 != null && buff2 != null)
            {
                if (buff1.next == null)
                {
                    buff1.next = buff2;
                    break;
                }

                if (buff2.val <= buff1.next.val)
                {
                    var buff2Next = buff2.next;
                    var buff1Next = buff1.next;

                    buff1.next = buff2;
                    buff2.next = buff1Next;
                    buff2 = buff2Next;
                }
                buff1 = buff1.next;
            }

            return result;
        }
    }
}
