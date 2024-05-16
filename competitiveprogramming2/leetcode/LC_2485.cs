
using System;
using System.Collections.Generic;
using System.Linq;

namespace competitiveprogramming.leetcode
{
    
    
    public class LC_2485
    {
        public int PivotInteger(int n)
        {
            var prefixSum = new List<int>();
            var prefixSumReversed = new List<int>();

            int sumForward = 0;
            int sumBackwards = 0;
            for (int i = 1; i <= n; i++)
            {
                sumForward += i;
                sumBackwards += n - (i - 1);
                prefixSum.Add(sumForward);
                prefixSumReversed.Insert(0, sumBackwards);
            }

            for (int i = 0; i < prefixSum.Count; i++)
            {
                if (prefixSum[i] == prefixSumReversed[i]) return i + 1;
            }

            return -1;
        }
        
    }

    
}

