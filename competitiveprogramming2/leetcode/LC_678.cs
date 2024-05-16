
using System;
using System.Collections.Generic;
using System.Linq;

namespace competitiveprogramming.leetcode
{
    public class LC_678
    {
        public bool CheckValidString(string s)
        {


            List<char> mutableString = s.ToList();
            for (int i = 0; i < mutableString.Count; i++)
            {
                if (mutableString[i] == ')')
                {
                    // look backwards for match
                    int foundStar = -1;
                    bool foundMatch = false;
                    for (int back = i; back >= 0; back--)
                    {
                        if (mutableString[back] == '(')
                        {
                            foundMatch = true;
                            mutableString[back] = '#';
                            mutableString[i] = '#';
                        }

                        if (mutableString[back] == '*') foundStar = back;
                    }

                    if (!foundMatch && foundStar < 0) return false;
                    if (!foundMatch && foundStar > 0)
                    {
                        mutableString[foundStar] = '#';
                        mutableString[i] = '#';
                    }

                }
            }

            mutableString.RemoveAll(it => it == '#');
            mutableString.RemoveAll(it => it == '*');
            if (mutableString.Count == 0) return true;
            return false;
        }
        
        
    }
    

}

