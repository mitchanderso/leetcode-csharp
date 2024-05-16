
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace competitiveprogramming.leetcode
{
    public class LC_3115
    {
        
        Dictionary<int, bool> primes2 = new Dictionary<int, bool>
        {
    { 2, true },

    {2, true },

    {3, true },

    {5, true },

    {7, true },

    {11, true },

    {13, true },
    {17, true },
    {19, true },
    {23, true },
    {29, true },
    {31, true },
    {37, true },
    {41, true },
    {43, true },
    {47, true },
    {53, true },
    {59, true },
    {61, true },
    {67, true },
    {71, true },
    {73, true },
    {79, true },
    {83, true },
    {89, true },
    {97, true }};
        
        
        // private int[] primes = new[]
        //     { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
        public int MaximumPrimeDifference(int[] nums)
        {
            List<Tuple<int, int>> primesAndLocations = new List<Tuple<int, int>>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (primes2.ContainsKey(nums[i]))
                {
                    primesAndLocations.Add(new Tuple<int, int>(nums[i], i));
                }
            }

            int maxDistance = 0;
            
            for (int i = 0; i < primesAndLocations.Count; i++)
            {
                var primeLocation = primesAndLocations[i].Item2;
                
                maxDistance = Math.Max(maxDistance, primesAndLocations[primesAndLocations.Count - 1].Item2 - primeLocation);
                
            }


            return maxDistance;
        }
        
    }


}

