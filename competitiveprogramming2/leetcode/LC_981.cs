
using System;
using System.Collections.Generic;
using System.Linq;

namespace competitiveprogramming.leetcode
{
    
    
    public class LC_981
    {
        private Dictionary<String, List<(int, String)>> timeMap = new Dictionary<String, List<(int, String)>>();
        public void Set(string key, string value, int timestamp) {
            if (timeMap.ContainsKey(key))
            {
                timeMap[key].Add((timestamp, value));
            }
            else
            {
                List < (int, String) > list = new List<(int, String)> ();
                list.Add((timestamp, value));
                timeMap.Add(key, list);
            }
        }
    
        public string Get(string key, int timestamp) {
            Console.WriteLine($"Called with {key} and {timestamp}");
            if (timeMap.ContainsKey(key))
            {
                var list = timeMap[key];
                var (ts, vall) = list.FindLast(elem => elem.Item1 <= timestamp);
                
                return vall;
            }

            
            return "";
            
        }
        
    }

 
}

