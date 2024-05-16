
using System;
using System.Collections.Generic;
using System.Linq;

namespace competitiveprogramming.leetcode
{
    
    
    public class LC_3090
    {
        public int MaximumLengthSubstring(string s)
        {
            int windowStart = 0;
            int windowEnd = 0;
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            int max = 0;
            while (windowEnd < s.Length)
            {
                
                if (charCount.ContainsKey(s[windowEnd]))
                {
                    charCount[s[windowEnd]] = charCount[s[windowEnd]] + 1;
                }
                else
                {
                    charCount[s[windowEnd]] = 1;
                }
                
                int count = charCount[s[windowEnd]];

                while (count > 2)
                {
                    charCount[s[windowStart]] = charCount[s[windowStart]] - 1;
                    if (s[windowStart] == s[windowEnd])
                    {
                        count--;
                    }

                    windowStart++;
                }

                if (windowEnd - windowStart  + 1 > max)
                {
                    max = windowEnd - windowStart + 1;
                }

                windowEnd++;


            }

            return max;
        }
        
    }

    
}

