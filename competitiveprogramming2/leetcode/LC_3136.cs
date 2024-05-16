
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;

namespace competitiveprogramming.leetcode
{
    public class LC_3136
    {
        private char[] vowels = new[] { 'a', 'e', 'i', 'o', 'u' };
        private char[] allowedSymbols = new[] { '@' , '#', '$' };
        public bool IsValid(string word)
        {
            if (word.Length < 3) return false;
            if (word.Any(x => allowedSymbols.Contains(char.ToLower(x)))) return false;
            if (!word.Any(x => vowels.Contains(char.ToLower(x)))) return false;
            
            // No consonants
            if (word.Where(x => x > 57).All(x => vowels.Contains(char.ToLower(x)))) return false;

            return true;
        }
        
    }


}

