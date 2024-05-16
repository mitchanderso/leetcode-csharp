
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace competitiveprogramming.leetcode
{
    public class LC_310
    {
        
        public IList<int> FindMinHeightTrees(int n, int[][] edges)
        {
            if (n == 1) return new List<int>{0};
            var connections = new List<Tuple<int,List<int>>>();
            for (int i = 0; i < n; i++)
            {
                connections.Add(new Tuple<int, List<int>>(i, new List<int>()));
            }
            foreach (var edge in edges)
            {
                var to = edge[0];
                var from = edge[1];
                connections[to].Item2.Add(from);
                connections[from].Item2.Add(to);
            }

            while (connections.Count > 2)
            {
                // Find all the leafs
                var leaveIndices = new List<int>();
                connections.RemoveAll(i =>
                {
                    if (i.Item2.Count == 1)
                    {
                        leaveIndices.Add(i.Item1);
                        return true;
                    }

                    return false;
                });
                // Update connections
                foreach (var connection in connections)
                {
                    connection.Item2.RemoveAll(i => leaveIndices.Contains(i));
                }
                
            }


            return connections.Select(i => i.Item1).ToList();
        }
       
       
        
    }


}

