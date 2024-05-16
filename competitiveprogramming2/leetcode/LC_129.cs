
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace competitiveprogramming.leetcode
{
    public class LC_129
    {
        public int SumNumbers(TreeNode root)
        {
            var rc = recursiveSum(root, new List<int>());
             Console.WriteLine();
             Console.WriteLine(rc);
             Console.WriteLine("----");
            return 55;
        }

        public int recursiveSum(TreeNode root, List<int> numbers)
        {
            var sum = 0;
            numbers.Add(root.val);
            Console.WriteLine($"Doing root {root.val}");
            if (root.left == null && root.right == null) 
            {
                Console.WriteLine($"Returning from node its numbers are ");
                var numberString = "";

                var number = int.Parse(string.Join("", numbers));
                sum += number;
            }
            if (root.left != null)
            {
                Console.WriteLine("GOing left");
                sum += recursiveSum(root.left, numbers);
            }
            if (root.right != null)
            {
                Console.WriteLine("GOing right");
                sum += recursiveSum(root.right, numbers);
            }

            numbers.RemoveAt(numbers.Count - 1);
            Console.WriteLine($"Returning from root {root.val}");
            return sum;
        }
       
        
    }


}

