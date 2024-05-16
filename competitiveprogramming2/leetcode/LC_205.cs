
using System;
using System.Collections.Generic;
using System.Linq;

namespace competitiveprogramming.leetcode
{
    public class LC_205
    {
        public bool IsIsomorphic(string s, string t)
        {
            Dictionary<Char, Char> dict = new Dictionary<char, char>();
            for (int i = 0;  i < s.Length; i++)
            {
                if (dict.ContainsKey(s[i]) && dict[s[i]] != t[i])
                {
                    return false;
                }
                
                // if (dict.ContainsKey(s[i]) && dict.ContainsValue())
                if (!dict.ContainsKey(s[i]) && dict.ContainsValue(t[i]))
                {
                    return false;
                }
                if (!dict.ContainsKey(s[i]))
                {
                    dict.Add(s[i], t[i]);
                }
            }
            
            return true;
        } 
        
    }
    

}

