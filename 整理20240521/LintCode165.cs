using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    internal class LintCode165
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode p1 = l1;
            ListNode p2 = l2;
            ListNode dummy = new ListNode(-1);
            ListNode cur = dummy;
            while (p1 != null && p2 != null)
            {
                if (p1.val >= p2.val)
                {
                    cur.next = p2;
                    p2 = p2.next;
                }
                else
                {
                    cur.next = p1;
                    p1 = p1.next;
                }
                cur = cur.next;
            }
            while (p1 != null)
            {
                cur.next = p1;
                cur = cur.next;
                p1 = p1.next;
            }
            while (p2 != null)
            {
                cur.next = p2;
                cur = cur.next;
                p2 = p2.next;
            }
            return dummy.next;
        }
    }
}
