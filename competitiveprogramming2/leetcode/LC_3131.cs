
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace competitiveprogramming.leetcode
{
    public class LC_3131
    {
        
        public int AddedInteger(int[] nums1, int[] nums2)
        {
            var list1 = nums1.ToList();
            var list2 = nums2.ToList();
            list1.Sort();
            list2.Sort();

            return nums2[0] - nums1[0];
        }
       
       
        
    }


}

