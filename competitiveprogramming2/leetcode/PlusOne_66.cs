using System.Linq;
using System.Runtime.CompilerServices;

namespace competitiveprogramming.leetcode
{
    public class PlusOne_66
    {
        public int[] PlusOne(int[] digits)
        {
            
            var len = digits.Length;
            var multiplier = 1;
            var reversed = digits.Reverse().ToArray();
            var ans = reversed.Select(x =>
            {
                var newVal = x * multiplier;
                multiplier = multiplier * 10;
                return newVal;
            }).Aggregate((acc, cur) => acc + cur);
               
            
            
             int[] ans2 = {1,2,3};
             return ans2;
        }
        
    }
    

}

