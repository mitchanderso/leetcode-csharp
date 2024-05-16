
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;

namespace competitiveprogramming.leetcode
{
    public class LC_2373
    {
        
        public int[][] LargestLocal(int[][] grid)
        {
            var ans = new List<List<int>>();
         
            for (int rowStart = 0; rowStart < grid.Length - 2; rowStart++)
            {
                var ansRow = new List<int>();
                for (int colStart = 0; colStart < grid[0].Length - 2; colStart++)
                {
                    var localMax = -1;
                    
                    for (int i = rowStart; i < rowStart + 3; i++)
                    {
                        for (int j = colStart; j < colStart + 3; j++)
                        {
                            localMax = Math.Max(localMax, grid[i][j]);
                        }
                    }
                    ansRow.Add(localMax);
                }
                ans.Add(ansRow);
            }

            return ans.Select(a => a.ToArray()).ToArray();
        }
        
    }


}

