
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;

namespace competitiveprogramming.leetcode
{
    public class LC_2000
    {
        
        public string ReversePrefix(string word, char ch)
        {
            
            var idx = word.IndexOf(ch);
            if (idx <= 0) return word;
            var ans = new StringBuilder();
            for (int i = 0; i < word.Length; i++)
            {
                if (i <= idx)
                {
                    ans.Append(word[idx - i]);
                }
                else
                {
                    ans.Append(word[i]);
                }
            }

            return ans.ToString();
        }
        
    }


}

