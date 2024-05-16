
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;

namespace competitiveprogramming.leetcode
{
    public class LC_3147
    {
        
        public int MaximumEnergy(int[] energy, int k)
        {
            var dp = new int[energy.Length];
       
            for (int i = 0; i < energy.Length; i++)
            {
                if (i - k < 0) dp[i] = energy[i];
                else
                {
                    if (dp[i - k] < 0) dp[i] = energy[i];
                    else dp[i] = dp[i - k] + energy[i];
                }
            }

            var maxIdx = -1;
            var max = int.MinValue;
            for (int i = dp.Length - k; i < dp.Length; i++)
            {
                if (dp[i] > max)
                {
                    max = dp[i];
                    maxIdx = i;
                }
            }

            return dp[maxIdx];
        }
        
    }


}

