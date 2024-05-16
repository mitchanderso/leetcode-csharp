
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

namespace competitiveprogramming.leetcode
{
    public class LC_42
    {
        
        public int Trap(int[] height)
        {
            var maxLeftHeight = new int[height.Length];
            maxLeftHeight[0] = height[0];
            for (int i = 1; i < height.Length; i++)
            {
                maxLeftHeight[i] = Math.Max(maxLeftHeight[i - 1], height[i]);
            }
            
            var maxRightHeight = new int[height.Length];
            maxRightHeight[height.Length - 1] = height[height.Length - 1];
            for (int i = height.Length - 2; i >= 0; i--)
            {
                maxRightHeight[i] = Math.Max(maxRightHeight[i + 1], height[i]);
            }

            var volume = 0;
            for (int i = 0; i < height.Length; i++)
            {
                Console.WriteLine($"Volume at {i} is {Math.Min(maxLeftHeight[i], maxRightHeight[i]) - height[i]}");
                volume += Math.Min(maxLeftHeight[i], maxRightHeight[i]) - height[i];
            }

            return volume;
        }
        
    }


}

