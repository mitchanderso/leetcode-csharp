
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
    public class LC_2812
    {
        private int[][] directions = new[]
        {
            new[] { -1, 0 },
            new[] { 1, 0 },
            new[] { 0, -1 },
            new[] { 0, 1 },
        };

     

        public int dijkstras(IList<IList<int>> grid, int[,] distance, int [,] visited)
        {
            var width = grid[0].Count;
            var height = grid.Count;
            
            distance[0, 0] = grid[0][0];
            visited[0, 0] = 1;
            var pq = new PriorityQueue<int[], int[]>(Comparer<int[]>.Create((x,y) => y[2] - x[2]));
         
            pq.Enqueue([0,0,grid[0][0]], [0,0,grid[0][0]]);

            while (pq.Count > 0)
            {
                var current = pq.Dequeue();
                visited[current[0], current[1]] = 1;
                Console.WriteLine($"At row = ({current[0]}) col = {current[1]}");

                if (current[0] == height - 1 && current[1] == width - 1)
                {
                    return current[2];
                }
                foreach (var direction in directions)
                {
                    var newRow = current[0] + direction[0];
                    var newCol = current[1] + direction[1];

                    if (newRow >= 0 && newCol >= 0 && newRow < height && newCol < width && visited[newRow, newCol] != 1)
                    {
                        var newDist = Math.Min(grid[newRow][newCol], current[2]);
                        distance[newRow, newCol] = newDist;
                        
                        pq.Enqueue([newRow, newCol, distance[newRow, newCol]], [newRow, newCol, distance[newRow, newCol]]);

                    }
                }
            }

            return 0;


        }
        
        public int MaximumSafenessFactor(IList<IList<int>> grid)
        {
            var width = grid[0].Count;
            var height = grid.Count;
            var thievesQ = new Queue<int[]>();
            var visited = new int[height, width];

            var distance = new int[height, width];
            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    if (grid[row][col] == 1)
                    {
                        thievesQ.Enqueue([row, col]);
                        grid[row][col] = 0;
                        visited[row, col] = 1;
                    }
                    distance[row, col] = int.MaxValue;
                }
            }

            var dist = 1;
            while (thievesQ.Count > 0)
            {
                var qSize = thievesQ.Count;
                for (int i = 0; i < qSize; i++)
                {
                    var current = thievesQ.Dequeue();
                    foreach (var direction in directions)
                    {
                        var newRow = current[0] + direction[0];
                        var newCol = current[1] + direction[1];

                        if (newRow >= 0 && newCol >= 0 && newRow < height && newCol < width && visited[newRow, newCol] != 1)
                        {
                            if (grid[newRow][newCol] == 0) grid[newRow][newCol] = dist;
                            else grid[newRow][newCol] = Math.Min(grid[newRow][newCol], dist);
                            visited[newRow, newCol] = 1;
                            thievesQ.Enqueue([newRow, newCol]);
                        }
                    }
                }

                dist++;
            }

            return dijkstras(grid, distance, new int[height, width]);

        }

        
      
        
    }


}

