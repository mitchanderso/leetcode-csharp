
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;

namespace competitiveprogramming.leetcode
{
    public class LC_3138
    {
        
        public int MinAnagramLength(string s) {
            // The max possible length is half the string length
            var maxPossibleLength = s.Length / 2;
            var anagramEnd = 1;
            for (int i = 1; i <= maxPossibleLength; i++)
            {
                if (s.Length % i == 0 && checkAnagramOfLength(i, s))
                {
                    return i;
                }
            }

            return s.Length;
        }

        public bool checkAnagramOfLength(int length, string s)
        {
            int[] countAnagramChars = new int[26]; 
            for (int testAnagram = 0; testAnagram < length; testAnagram++)
            {
                countAnagramChars[s[testAnagram] - 'a']++;
            }
            
            for (int nextAnagramStart = length; nextAnagramStart < s.Length; nextAnagramStart += length)
            {
                int[] countNextAnagramChars = new int[26];
                Console.WriteLine($"Starting next check at {nextAnagramStart}");
                for (int nextAnagramItr = nextAnagramStart;
                     nextAnagramItr < nextAnagramStart + length;
                     nextAnagramItr++)
                {
                    countNextAnagramChars[s[nextAnagramItr] - 'a']++;
                }
                
                // Evaluate they are the same?
                for (int i = 0; i < 26; i++)
                {
                    if (countAnagramChars[i] != countNextAnagramChars[i]) return false;
                }
            }

            return true;
        }
        
    }


}

