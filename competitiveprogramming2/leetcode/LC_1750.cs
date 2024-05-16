
using System;
using System.Collections.Generic;
using System.Linq;

namespace competitiveprogramming.leetcode
{
    public class LC_1750
    {
        public int MinimumLength(string s)
        {

  
            while (s.Length > 1 && s.First() == s.Last())
            {
                var left = 0;
                
                char ch = s.First();
                
                while (left < s.Length && s[left] == ch) left++;
                s = s.Remove(0, left);

                var right = s.Length - 1;
                while (s.Length > 1 && right >= 0 && s[right] == ch) right--;
                int rightCount = s.Length - right - 1;
                if (rightCount > 0 ) s = s.Remove(s.Length - rightCount, rightCount);
                
                //Console.WriteLine($"Removed left string is now {s}");
                
                //Console.WriteLine($"Removed right string is now {s}");
                Console.WriteLine($" string is now {s}");
   
            }

            return s.Length;
        }
        
    }
    

}

