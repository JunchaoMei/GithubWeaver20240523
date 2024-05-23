using System;
using System.Collections.Generic;

namespace LeetCode
{
    internal class LintCode173
    {
        public ListNode InsertionSortList(ListNode head)
        {
            ListNode dummy = new ListNode(-1);
            ListNode cur = head;
            while (cur != null)
            {//1, 3, 2, 0
                ListNode dCur = dummy;// -1
                while (cur.val > dCur.next?.val)
                {
                    dCur = dCur.next;
                }
                ListNode next = dCur.next;//null
                dCur.next = cur;//-1->1
                cur = cur.next;
                dCur.next.next = next;
            }
            return dummy.next;
        }
    }
}
