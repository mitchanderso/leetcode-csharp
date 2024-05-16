
using System;
using System.Collections.Generic;
using System.Linq;

namespace competitiveprogramming.leetcode
{
    
    
    public class LC_91
    {
        public int NumDecodings(string s)
        {
            var memo = new Dictionary<int, int>();
            return NumDecodingsR(s, 0, memo);
        }

        public int NumDecodingsR(string s, int pos, Dictionary<int, int> memo)
        {
            if (pos == s.Length)
            {
                    memo[pos] = 1;
                    return 1;
             }

            if (s[pos] == '0')
            {
                memo[pos] = 0;
                return 0;
            }
            
            if (memo.ContainsKey(pos)) return memo[pos];

            
            var ans = NumDecodingsR(s, pos + 1, memo);
            if (pos < s.Length - 1 && (s[pos] == '1' || (s[pos] == '2' && s[pos + 1] <= '6')  ))
            {
                ans += NumDecodingsR(s, pos + 2, memo);
            }

            memo[pos] = ans;
            return ans;
        }
        
    }

 
}

