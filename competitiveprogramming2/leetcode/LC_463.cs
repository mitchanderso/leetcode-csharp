
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

namespace competitiveprogramming.leetcode
{
    public class LC_463
    {
        private Tuple<int, int>[] directions = new[]
        {
            new Tuple<int, int>(1, 0),
            new Tuple<int, int>(-1, 0),
            new Tuple<int, int>(0, 1),
            new Tuple<int, int>(0, -1),
        };
        public int IslandPerimeter(int[][] grid)
        {
            var ans = 0;
            for (int y = 0; y < grid.Length; y++)
            {
                for (int x = 0; x < grid[0].Length; x++)
                {
                    if (grid[y][x] == 1)
                    {
                        foreach (var (xidsp, ydisp) in directions)
                        {
                            var newPosX = xidsp + x;
                            var newPosY = ydisp + y;
                            if (newPosX < 0 || newPosX >= grid[0].Length || newPosY >= grid.Length || newPosY < 0)
                            {
                                ans++;
                            } else if (grid[newPosY][newPosX] == 0) ans++;
                        }
                    }
                }
            }

            return ans;
        }
       
        
    }


}

