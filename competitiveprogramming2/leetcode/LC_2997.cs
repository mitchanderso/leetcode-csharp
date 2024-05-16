
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace competitiveprogramming.leetcode
{
    public class LC_2997
    {
        
        public int MinOperations(int[] nums, int k)
        {
            var xord = nums.Aggregate((acc, curr) => curr ^ acc);
            //Console.WriteLine($"The xord value is ${xord} as binary {Convert.ToString(xord, 2)}");
            var expected = Convert.ToString(k, 2).PadLeft(32,'0');
            var actual = Convert.ToString(xord, 2).PadLeft(32, '0');
            Console.WriteLine($"Expected = {expected}");
            Console.WriteLine($"Actual   = {actual}");
            var ans = 0;
            for (int i = 0; i < expected.Length; i++)
            {
                if (expected[i] != actual[i]) ans++;
            }
            return ans;
        }
       
       
        
    }


}

