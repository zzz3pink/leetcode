using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
//Output: 7 -> 0 -> 8
//Explanation: 342 + 465 = 807.

namespace _2.Add_Two_Numbers
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int val = 0;
            ListNode prenode = new ListNode(0);
            ListNode lastnode = prenode;
            while(l1 !=null || l2!=null ||val!=0)
            {
                val = val + (l1 == null ? 0 : l1.val) + (l2 == null ? 0 : l2.val);
                lastnode.next = new ListNode(val % 10);
                lastnode = lastnode.next;
                val = val / 10;
                l1 = l1 == null ? null : l1.next;
                l2 = l2 == null ? null : l2.next;
            }
            return prenode.next;
        }
    }

    public class Test
    {
        static ListNode generateList(int[] vals)
        {
            ListNode res = null;
            ListNode last = null;
            foreach (var val in vals)
            {
                if (res is null)
                {
                    res = new ListNode(val);
                    last = res;
                }
                else
                {
                    last.next = new ListNode(val);
                    last = last.next;
                }
            }
            return res;
        }
        static void printList(ListNode l)
        {
            while (l != null)
            {
                Console.Write($"{l.val},");
                l = l.next;
            }
            Console.WriteLine("");
        }

        static void Main()
        {
            var l1 = generateList(new int[] { 7, 1, 6 });
            var l2 = generateList(new int[] { 5, 9, 2 });
            printList(l1);
            printList(l2);
            Solution s = new Solution();
            var sum = s.AddTwoNumbers(l1, l2);
            printList(sum);
            Console.ReadKey();
        }
    }
}

