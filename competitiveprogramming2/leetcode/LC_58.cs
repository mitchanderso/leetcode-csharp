
using System;
using System.Collections.Generic;
using System.Linq;

namespace competitiveprogramming.leetcode
{
    public class LC_58
    {
        public int LengthOfLastWord(string s)
        {
            int lastSpaceBlock = -1;
            Boolean foundCharacter = false;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] != ' ')
                {
                    foundCharacter = true;
                }

                if (!foundCharacter)
                {
                    lastSpaceBlock = i;
                }

                if (foundCharacter && s[i] == ' ')

            {
                    if (lastSpaceBlock == -1)
                    {
                        return (s.Length) - (i + 1);
                    }

            
                    return lastSpaceBlock - (i + 1);
                    // return ans
                }
            }

            if (lastSpaceBlock == -1)
            {
                return s.Length;
            }

            return lastSpaceBlock;

        }
        
    }
    

}

