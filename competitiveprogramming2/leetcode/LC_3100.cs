
using System;
using System.Collections.Generic;
using System.Linq;

namespace competitiveprogramming.leetcode
{
    public class LC_3100
    {
        public int MaxBottlesDrunk(int numBottles, int numExchange)
        {
            int emptyBottles = 0;
            int drank = 0;
            while (numBottles > 0 || emptyBottles >= numExchange)
            {
                while (emptyBottles >= numExchange)
                {
                    emptyBottles = Math.Max(emptyBottles - numExchange, 0);
                    numBottles ++;
                    numExchange++;
                }
                drank += numBottles;
                emptyBottles += numBottles;
                numBottles = 0;
            }

            return drank;
        }
        
    }
    

}

