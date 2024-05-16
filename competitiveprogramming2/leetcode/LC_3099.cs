
using System;
using System.Collections.Generic;
using System.Linq;

namespace competitiveprogramming.leetcode
{
    public class LC_3099
    {
        public int SumOfTheDigitsOfHarshadNumber(int x)
        {
            
            int sumOfString = x.ToString().Aggregate(0, (acc, current) => acc + (current - '0'));
            if ((x % sumOfString) == 0) return sumOfString;
            return -1;
        }
        
    }
    

}

