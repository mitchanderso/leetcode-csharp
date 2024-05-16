
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;

namespace competitiveprogramming.leetcode
{
    public class LC_2816
    {
        
        public ListNode DoubleIt(ListNode head) {
            var number = new List<ListNode>();
            var nhead = head;
            while (nhead != null) {
                number.Add(nhead);
                nhead = nhead.next;
            }

            var carry = 0;
            for (int i = number.Count - 1; i >= 0; i--)
            {
                var n = number[i].val;
                
                number[i].val = (n * 2 + carry) % 10;
                carry = (n * 2) / 10;
            }

            if (carry > 0)
            {
                var ln = new ListNode(carry, head);
                return ln;
            }

            return head;
        }
        
    }


}

