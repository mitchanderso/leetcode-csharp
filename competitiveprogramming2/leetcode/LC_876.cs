
using System;
using System.Collections.Generic;
using System.Linq;

namespace competitiveprogramming.leetcode
{
     public class ListNode {
         public int val;
         public ListNode next;
         public ListNode(int val=0, ListNode next=null) {
                 this.val = val;
                 this.next = next;
             }
     }

    public class LC_876
    {
        public ListNode MiddleNode(ListNode head)
        {
            var length = 0;
            var headCopy = head;
            while (headCopy != null)
            {
                length++;
                headCopy = headCopy.next;
            }

            for (int i = 0; i < length / 2; i++)
            {
                head = head.next;
            }

            return head;

        }
        
    }
    

}

