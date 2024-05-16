
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace competitiveprogramming.leetcode
{
    public class LC_3132
    {
        public int MinimumAddedInteger(int[] nums1, int[] nums2)
        {
            var answers = new List<int>();
            var sorted1 = nums1.ToList();
            var sorted2 = nums2.ToList();
            sorted1.Sort();
            sorted2.Sort();

            var maxDifference = Math.Max(
                    Math.Abs(sorted1[0] - sorted2[sorted2.Count() - 1]),
                    Math.Abs(sorted2[0] - sorted1[sorted1.Count() - 1])
                );

            //var maxDifference = Math.Max(Math.Abs(nums1max - nums2min), Math.Abs(nums2max - nums1min));
            
            for (int i = 0; i <= maxDifference; i++)
            {

                var negiMap = nums2.ToList().GroupBy(x => x).ToDictionary(y => y.Key, y => y.Count());
                var posiMap = nums2.ToList().GroupBy(x => x).ToDictionary(y => y.Key, y => y.Count());
                var posiCount = 0;
                var negiCount = 0;
                for (int j = 0; j < nums1.Length; j++)
                {
                    var posi = nums1[j] + i;
                    var negi = nums1[j] - i;
                    if (posiMap.ContainsKey(posi) && posiMap[posi] > 0)
                    {
                        posiMap[posi]--;
                        posiCount++;
                    }
                    if (negiMap.ContainsKey(negi) && negiMap[negi] > 0)
                    {
                        negiMap[negi]--;
                        negiCount++;
                    }
                }

                if (negiCount == nums2.Length) answers.Add(-i);
                if (posiCount == nums2.Length) answers.Add(i);
            }
            

            return answers.Min();
        }



    }


}

