
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;

namespace competitiveprogramming.leetcode
{
    public class LC_1219
    {
        private int[][] directions = new[]
        {
            new[] { -1, 0 },
            new[] { 1, 0 },
            new[] { 0, -1 },
            new[] { 0, 1 },
        };


        
        public int GetMaximumGold(int[][] grid)
        {
            var ans = 0;
            for (int r = 0; r < grid.Length; r++)
            {
                for (int c = 0; c < grid[0].Length; c++)
                {
                    ans = Math.Max(ans, dfs(r, c, grid, new int[grid.Length, grid[0].Length]));
                }
            }
            return ans;
        }

        public int dfs(int row, int col, int[][] grid, int[,] visited)
        {
            // Left, right, up, down
            var sum = 0;
            visited[row ,col] = 1;
            foreach (var direction in directions)
            {
                if (row + direction[0] >= 0 && row + direction[0] < grid.Length
                                            && col + direction[1] >= 0 && col + direction[1] < grid[0].Length
                                            && visited[row + direction[0],col + direction[1]] != 1
                                            && grid[row + direction[0]][col + direction[1]] > 0
                   )
                {
                    
                    sum = Math.Max(sum, dfs(row + direction[0], col + direction[1], grid, visited));
                }
            }

            visited[row,col] = 0;
            return sum + grid[row][col];
        }
        
    }


}

