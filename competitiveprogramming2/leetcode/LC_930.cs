
using System;
using System.Collections.Generic;
using System.Linq;

namespace competitiveprogramming.leetcode
{


    public class LC_930
    {

        public int NumSubarraysWithSum(int[] nums, int goal)
        {
            return NumSubarraysWithSumR(nums, goal, 0, "", 0);

        }

        private int NumSubarraysWithSumR(int[] nums, int goal, int pos, string workingString, int workingSum)
        {

            if (workingSum > goal)
            {
                Console.WriteLine("Got greater....");
                return 0;
            }


            if (pos >= nums.Length)
            {
                
                if (workingSum == goal)
                {
                    Console.WriteLine(workingString + " - ");
                    return 1;
                }

                return 0;
            }

            var numberOfWays = 0;

            // Select
            workingString += nums[pos];
            var select = NumSubarraysWithSumR(nums, goal, pos + 1, workingString, workingSum + nums[pos]);

            // Dont select
            workingString = workingString.Remove(workingString.Length - 1, 1);
            var dontSelect = NumSubarraysWithSumR(nums, goal, pos + 1, workingString, workingSum);

            numberOfWays += select;
            numberOfWays += dontSelect;


            return numberOfWays;
        }
    }


}

