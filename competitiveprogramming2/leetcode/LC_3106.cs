
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace competitiveprogramming.leetcode
{
    public class LC_3106
    {
        

        public string GetSmallestString(string s, int k)
        {
            var newString = "";
            var totalDistance = 0;

            for (int i = 0; i < s.Length; i++)
            {
                var currentChar = s[i];
                // Console.WriteLine($"String char is {currentChar}");
                for (int newCharNum = 0; newCharNum < 26; newCharNum++)
                {
                    
                    var distanceOne = Math.Abs(currentChar - (newCharNum + 97));
                    var distanceTwo = 26 - distanceOne;
                    if (distanceTwo == 26) distanceTwo = 0;
                    char toIns = (char) (newCharNum + 97);
                    // Console.WriteLine($"Dis1 distance to {toIns} is {distanceOne}");
                    // Console.WriteLine($"Dis2 distance to {toIns} is {distanceTwo}");
                    // Console.WriteLine();
                    if (totalDistance + distanceOne <= k || totalDistance + distanceTwo <= k)
                    {
                        
                        newString += toIns;
                        totalDistance += Math.Min(distanceOne, distanceTwo);
                        break;
                    }
                }
            }

            return newString;
        }
       
       
        
    }


}

