
using System;
using System.Collections.Generic;
using System.Linq;

namespace competitiveprogramming.leetcode
{
   

    public class LC_28
    {
        public int StrStr(string haystack, string needle)
        {

            var newLeft = -1;
            var left = 0;
            var right = 0;
            var needlePos = 0;
            while (right < haystack.Length)
            {
                var count = 0;
                while (right < haystack.Length && haystack[right] == needle[needlePos])
                {
                    count++;
                    if (count == needle.Length)
                    {
                        return left;
                    }
                    if (haystack[right] == needle[0] && needlePos > 0 && newLeft == -1)
                    {
                        newLeft = right;
                    }
                    needlePos++;
                    
                    right++;
                }

                needlePos = 0;

                if (newLeft > 0)
                {
                    left = newLeft;
                    right = newLeft;
                    newLeft = -1;
                }
                else
                {
                    //right++;
                    left++;
                    right = left;
                }
            }

            return -1;
        }
        
    }
    

}

