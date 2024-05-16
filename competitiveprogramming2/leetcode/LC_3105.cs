
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace competitiveprogramming.leetcode
{
    public class LC_3105
    {
        

        public int LongestMonotonicSubarray(int[] nums)
        {
            if (nums.Length == 1) return 1;
            var longestIncrease = 1;
            var longestDecrease = 1;
            var ans = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                var previous = nums[i - 1];
                if (nums[i] > previous)
                {
                    longestIncrease++;
                    ans = Math.Max(ans, longestIncrease);
                    longestDecrease = 1;
                }

                if (nums[i] < previous)
                {
                    longestIncrease = 1;
                    longestDecrease++;
                    ans = Math.Max(ans, longestDecrease);
                }

                if (nums[i] == previous)
                {
                    longestIncrease = 1;
                    longestDecrease = 1;
                }
            }
            return ans;
        }
       
       
        
    }


}

