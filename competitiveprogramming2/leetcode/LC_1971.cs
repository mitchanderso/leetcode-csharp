
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace competitiveprogramming.leetcode
{
    public class LC_1971
    {
        
        public int NumberOfSpecialChars(string word) {
            var upper = new int[26];
            var lower = new int[26];
            var ans = 0;
            for (int i = 0; i < word.Length; i++)
            {
                var arrayIdx = -1;
                if (word[i] - 65 > 26)
                {
                    // lowercase
                    lower[word[i] - 97]++;
                    arrayIdx = word[i] - 97;
                }
                else
                {
                    //upper case
                    arrayIdx = word[i] - 65;
                    upper[word[i] - 65]++;
                }
                
                

                if (upper[arrayIdx] > 0 && lower[arrayIdx] > 0)
                {
                    ans++;
                    upper[arrayIdx] = -1000;
                    lower[arrayIdx] = -1000;
                }
            }

            return ans;
        }
        
        public bool ValidPath(int n, int[][] edges, int source, int destination)
        {
            if (edges.Length == 0)
            {
                if (source == destination) return true;
                else return false;
            }
            
            var outboundEdges = new Dictionary<int, List<int>>();
            var visited = new bool[n];
            for (int i = 0; i < n; i++)
            {
                visited[i] = false;
            }
            
            foreach (int[] edge in edges)
            {
                var from = edge[0];
                var to = edge[1];
                if (outboundEdges.ContainsKey(from))
                {
                    outboundEdges[from].Add(to);
                }
                else
                {
                    var list = new List<int> { to };
                    outboundEdges.Add(from, list);
                }
                
                if (outboundEdges.ContainsKey(to))
                {
                    outboundEdges[to].Add(from);
                }
                else
                {
                    var list = new List<int> { from };
                    outboundEdges.Add(to, list);
                }
            }

            var bfsQ = new Queue<int>();
            bfsQ.Enqueue(source);
            while (bfsQ.Count > 0)
            {
                var current = bfsQ.Dequeue();
                visited[current] = true;
                var adjacent = outboundEdges[current];
                foreach (int adjacentNode in adjacent)
                {
                    if (adjacentNode == destination) return true;
                    if (!visited[adjacentNode])
                    {
                        bfsQ.Enqueue(adjacentNode);
                    }
                }
            }

            return false;
        }
       
        
    }


}

