
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace competitiveprogramming.leetcode
{

    public class LC_752
    {
        private int[][] directions = new[]
        {
            new[] { 1, 0, 0, 0 },
            new[] { 0, 1, 0, 0 },
            new[] { 0, 0, 1, 0 },
            new[] { 0, 0, 0, 1 },
            new[] { -1, 0, 0, 0 },
            new[] { 0, -1, 0, 0 },
            new[] { 0, 0, -1, 0 },
            new[] { 0, 0, 0, -1 },
        };
        public int OpenLock(string[] deadends, string target)
        {
            var deadEndsSet = new HashSet<string>(deadends);
            

            if (deadEndsSet.Contains("0000")) return -1;

            var bfsQ = new Queue<string>();
            var visited = new Dictionary<string, bool>();
            var ans = 0;
            
            bfsQ.Enqueue("0000");
            visited.Add("0000", true);
            while (bfsQ.Count > 0)
            {
                var bfsCount = bfsQ.Count;
                for (int i = 0; i < bfsCount; i++)
                {
                    var current = bfsQ.Dequeue();
                    
                    // Think about skipping ahead to cut down iterations?
                    if (current == target)
                    {
                        Console.WriteLine($"Current string won! {current}");
                        return ans;
                    }
                    foreach (var direction in directions)
                    {
                        var newString = new StringBuilder();
                        for (int j = 0; j < direction.Length; j++)
                        {
                            var modifier = direction[j];
                            var newChIndex = (((current[j] - 48) + modifier) + 100) % 10;
                            var newCha = (char)(newChIndex + 48);
                            newString.Append(newCha);
                            
                        }
                        if (!visited.ContainsKey(newString.ToString()) && !deadEndsSet.Contains(newString.ToString()))
                        {
                            Console.WriteLine($"The new string is {newString.ToString()} adding to Q");
                            visited.Add(newString.ToString(), true);
                            bfsQ.Enqueue(newString.ToString());

                        }
                    }
                }

                ans++;

            }

            return -1;
        }
    }


}

