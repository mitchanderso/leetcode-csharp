
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace competitiveprogramming.leetcode
{
    public class LC_1614
    {
        
        public int MaxDepth(string s)
        {
            // Stack<int> paren = new Stack<int>();
            int parenCount = 0;
            int maxDepth = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    maxDepth = Math.Max(maxDepth, parenCount);
                    parenCount++;
                }
                else if (s[i] == ')')
                {
                    maxDepth = Math.Max(maxDepth, parenCount);
                    parenCount--;
                }
                else
                {
                    maxDepth = Math.Max(maxDepth, parenCount);
                }

                int x = 7;
            }
            return maxDepth;
        }
    }


}

