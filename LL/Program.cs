using System;

namespace LL
{
     public class ListNode
    {
            public int val;
                 public ListNode next;
                public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

     public class Solution
        {
            public ListNode ReverseList(ListNode head)
            {

                var tail = new ListNode(head.val);
                var iter = head;
                while (iter.next != null)
                {

                    iter = iter.next;
                    var temp = new ListNode(iter.val, iter);
                    temp.next = tail;
                    tail = temp;
                }

                return head;
            }
            public ListNode ReverseList2(ListNode head)
            {

                var tail = new ListNode(head.val);
                var iter = head;
                while (iter.next != null)
                {
                    iter = iter.next;
                    tail = new ListNode(iter.val, iter){next = tail};
                }

                return head;
            }
    }
     class Program
    {
        static void Main(string[] args)
        {

            Solution s = new Solution();
            ListNode n ;
            n = new ListNode(5,null);
            n.next = new ListNode(5,null);
            n.next.next = new ListNode(7,null);
            n.next.next.next = new ListNode(9,null);
            s.ReverseList(n);
            Console.WriteLine("Hello World!");
        }
    }
}
