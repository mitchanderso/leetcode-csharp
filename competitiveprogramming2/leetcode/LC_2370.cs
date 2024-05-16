
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace competitiveprogramming.leetcode
{
    public class LC_2370
    {
        public int LongestIdealString(string s, int k)
        {
            int[] longestForChar = new int[26];
            var globalMax = 0;
            for (int i = 0; i < s.Length; i++)
            {
                var rangeMax = Math.Min(25, s[i] - 'a' + k);
                var rangeMin = Math.Max(0, s[i] - 'a' - k);
                var localMax = 0;
                for (int rangeItr = rangeMin; rangeItr <= rangeMax; rangeItr++)
                {
                    localMax = Math.Max(localMax, longestForChar[rangeItr]);
                }

                longestForChar[s[i] - 'a'] = localMax + 1;
                globalMax = Math.Max(globalMax, longestForChar[s[i] - 'a']);
            }

            return globalMax;
        }
       
       
        
    }


}

