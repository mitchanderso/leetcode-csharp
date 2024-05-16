
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace competitiveprogramming.leetcode
{
    public class LC_834
    {
        private List<List<int>> paths = new List<List<int>>();
        public int[] SumOfDistancesInTree(int n, int[][] edges)
        {
            var dict = new Dictionary<int, List<int>>();
            foreach (var edge in edges)
            {
                var start = edge[0];
                var dest = edge[1];
                if (!dict.ContainsKey(start))
                {
                    dict.Add(start, new List<int> { dest });
                }
                else
                {
                    dict[start].Add(dest);
                }
            }
            dfs(0, dict, new List<int> { 0 });
            
            // Use paths to know....
            var ans = new int[n];
            for (int src = 0; src < n; src++)
            {
                var dist = 0;
                for (int dst = 0; dst < n; dst++)
                {
                    if (src != dst)
                    {
                        
                        foreach (var path in paths)
                        {
                            var srcPos = path.FindIndex(x => x == src);
                            var destPos = path.FindIndex(x => x == dst);

                            if (srcPos > -1 && destPos > -1)
                            {
                                dist += Math.Abs(srcPos - destPos);
                                break;
                            }
                        }
                    }
                }

                ans[src] = dist;
            }

            return ans;
        }

        public void dfs(int n, Dictionary<int, List<int>> edges, List<int> path)
        {
            Console.WriteLine($"Doing node {n}");
            // Get Adjacent
            if (!edges.ContainsKey(n))
            {
                // Complete the path
                // Console.WriteLine($"{n} is a leaf node");
                paths.Add(path);
                //path.RemoveAt(path.Count - 1);
                return;
            }
            else
            {
                foreach (var dest in edges[n])
                {
                    var newPath = path.ToList();
                    newPath.Add(dest);
                    dfs(dest, edges, newPath);
                }
            }

        }



    }


}

