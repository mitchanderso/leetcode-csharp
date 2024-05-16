
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;

namespace competitiveprogramming.leetcode
{
    public class LC_2487
    {
        
        public ListNode RemoveNodes(ListNode head)
        {
            var nodeValues = new List<int>();
            var newHead = head;
            while (newHead != null)
            {
                nodeValues.Add(newHead.val);
                newHead = newHead.next;
            }

            var greatestToRight = new List<int>(nodeValues.Count);
            greatestToRight.Add(0);
            var maxSeen = 0;
            for (int i = nodeValues.Count - 2; i >= 0; i--)
            {
                maxSeen = Math.Max(maxSeen, nodeValues[i + 1]);
                greatestToRight.Insert(0, maxSeen);
            }
            


            var behind = new ListNode(-1, head);
            var originalBehind = behind;
            var current = head;
            var idx = 0;
            while (current != null)
            {
                if (greatestToRight[idx] > current.val)
                {
                    current = current.next;
                    behind.next = current;
                }
                else
                {
                    behind = current;
                    current = current.next;
                }
                idx++;
            }
            
            return originalBehind.next;
        }
        
    }


}

