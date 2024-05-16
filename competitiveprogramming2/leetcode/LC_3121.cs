
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace competitiveprogramming.leetcode
{
    public class CharCountLastPos
    {
        private int count;
        private int pos;
        private char letter;

        public CharCountLastPos(int count, int pos, char letter)
        {
            this.count = count;
            this.pos = pos;
            this.letter = letter;
        }

        public int Count
        {
            get => count;
            set => count = value;
        }

        public int Pos
        {
            get => pos;
            set => pos = value;
        }

        public char Letter
        {
            get => letter;
            set => letter = value;
        }
    }
    public class LC_3121
    {
        
        public int NumberOfSpecialChars(string word)
        {
            var lowerCase = new CharCountLastPos[26];
            var uppercase = new CharCountLastPos[26];
            
            for (int i = 0; i < word.Length; i++)
            {
                var letter = word[i];
                if (letter - 65 > 26)
                {
                    var oldCount = lowerCase[letter - 97]?.Pos ?? 0;
                    lowerCase[letter - 97] = new CharCountLastPos(oldCount + 1, i, letter);
                }
                else
                {
                    if (uppercase[letter - 65] == null)
                    { 
                        uppercase[letter - 65] = new CharCountLastPos(1, i, letter);
                    } 
                }
            }

            var ans = 0;
            for (int i = 0; i < 26; i++)
            {
                if (uppercase[i] != null && lowerCase[i] != null && lowerCase[i].Pos < uppercase[i].Pos)
                {
                    ans++;
                }

                
            }

            return ans;
        }
        public int NumberOfSpecialCharsOriginal(string word) {
            var upper = new int[26];
            var lower = new int[26];
            var ans = 0;
            for (int i = 0; i < word.Length; i++)
            {
                var arrayIdx = -1;
                if (word[i] - 65 > 26)
                {
                    // lowercase
                    lower[word[i] - 97]++;
                    arrayIdx = word[i] - 97;
                }
                else
                {
                    //upper case
                    arrayIdx = word[i] - 65;
                    upper[word[i] - 65]++;
                }
                
                

                if (upper[arrayIdx] > 0 && lower[arrayIdx] > 0)
                {
                    ans++;
                    upper[arrayIdx] = -1000;
                    lower[arrayIdx] = -1000;
                }
            }

            return ans;
        }

       
        
    }


}

