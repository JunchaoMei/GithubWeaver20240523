using System;
using System.Collections.Generic;

namespace LeetCode
{
    internal class LintCode98
    {
        public ListNode SortList(ListNode head)
        {
            return this.SortList(head, null);
        }

        public ListNode SortList(ListNode start, ListNode end)
        {
            // 题解说：
            // 上述过程可以通过递归实现。
            // 递归的终止条件是链表的节点个数小于或等于 1，
            // 即当链表为空或者链表只包含 1 个节点时，
            // 不需要对链表进行拆分和排序。
            // 所以看不懂以下判断
            // 为什么之判断第一个节点是否为空？
            // if (start == null) {
            //     return start;
            // }
            // 如果start和end相连, 则将第二个节点end切掉返回第一个节点start？为什么这样做？
            // if (start.next == end) {
            //     start.next = null;
            //     return start;
            // }

            // 自己写的也无效
            // if (start == null || end == null){
            //     return start;
            // }

            // if (start == null || start.next == null){
            //     return start;
            // }

            // if (start == null && end == null){
            //     return null;
            // }
            // if (start == null){
            //     return end;
            // }
            // if (end == null){
            //     return start;
            // }

            ListNode mid = this.GetMid(start, end);
            ListNode list1 = this.SortList(start, mid);

            // 此处为何sort 从mid开始而不是从mid.next?
            ListNode list2 = this.SortList(mid, end);
            return this.MergeTwoLists(list1, list2);
        }

        public ListNode GetMid(ListNode start, ListNode end)
        {
            ListNode slow = start;
            ListNode fast = start;
            while (fast != end)
            {
                slow = slow.next;
                fast = fast.next;
                if (fast != end)
                {
                    fast = fast.next;
                }
            }
            return slow;
        }

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
            if (p1 != null)
            {
                cur.next = p1;
            }
            if (p2 != null)
            {
                cur.next = p2;
            }
            return dummy.next;
        }
    }
}
