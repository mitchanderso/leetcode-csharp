
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;

namespace competitiveprogramming.leetcode
{
    public class LC_3146
    {
        
        public int FindPermutationDifference(string s, string t)
        {
            int[] posS = new int[26];
            int[] posT = new int[26];

            for (int i = 0; i < s.Length; i++)
            {
                posS[s[i] - 'a'] = i;
                posT[t[i] - 'a'] = i;
            }

            var sum = 0;
            for (int j = 0; j < posS.Length; j++)
            {
                var diff = Math.Abs(posS[j] - posT[j]);
                sum += diff;
            }

            return sum;
        }
        
    }


}

