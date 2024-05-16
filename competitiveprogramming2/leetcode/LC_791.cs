
using System;
using System.Collections.Generic;
using System.Linq;

namespace competitiveprogramming.leetcode
{
    public class LC_791
    {
        public string CustomSortString(string order, string s)
        {

            var orderList = new Dictionary<Char, int>();
            for(int i = 0; i < order.Length; i++)
            {
                orderList.Add(order[i], i);
                
            }

            var sorted = String.Concat(s.OrderBy(i =>
            {
                if (orderList.ContainsKey(i)) return orderList[i];
                else return 999;
            }));

            return sorted;
        }
        
    }
    

}

