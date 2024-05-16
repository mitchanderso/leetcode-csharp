
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace competitiveprogramming.leetcode
{
    public class LC_1137
    {
        private Dictionary<int, int> memo = new Dictionary<int, int>();
        public int Tribonacci(int n)
        {
            if (memo.ContainsKey(n)) return memo[n];
            if (n == 0) return 0;
            if (n <= 2) return 1;
            else
            {
                var ans = Tribonacci(n - 1) + Tribonacci(n - 2) + Tribonacci(n - 3);
                memo[n] = ans;
                return memo[n];
            }
        }
       
       
        
    }


}

