
using System;
using System.Collections.Generic;
using System.Linq;

namespace competitiveprogramming.leetcode
{
    public class LC_994
    {
        public int OrangesRotting(int[][] grid)
        {
            Queue<Tuple<int, int>> freshOranges = new Queue<Tuple<int, int>>();
            int width = grid[0].Length;
            int height = grid.Length;

            var directions = new[] { (0, 1), (0, -1), (1,0), (-1,0) };

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (grid[y][x] == 1) freshOranges.Enqueue(new Tuple<int, int>(x,y));
                }
            }

            
            int time = 0;
            while (freshOranges.Count != 0)
            {
                bool nothingHappened = true;
                List<Tuple<int, int>> newRotten = new List<Tuple<int, int>>();
                int freshOrangeCount = freshOranges.Count;
                for (int i = 0; i < freshOrangeCount; i++)
                {
                    
                    var freshOrange = freshOranges.Dequeue();
                    var wentRotten = false;

                    foreach (var direction in directions)
                    {
                        int newX = freshOrange.Item1 + direction.Item1;
                        int newY = freshOrange.Item2 + direction.Item2;
                        if (newX >= 0 && newY >= 0 && newX < width && newY < height && grid[newY][newX] == 2)
                        {
                            newRotten.Add(new Tuple<int, int>(freshOrange.Item1, freshOrange.Item2));
                            wentRotten = true;
                            nothingHappened = false;
                            break;
                        }
                    }
                    if (!wentRotten) freshOranges.Enqueue(new Tuple<int, int>(freshOrange.Item1, freshOrange.Item2));

                }

                foreach (var rotten in newRotten)
                {
                    grid[rotten.Item2][rotten.Item1] = 2;
                }

                if (nothingHappened) return -1;

                time++;
            }
            

            return time;
        }
        
    }
    

}

