
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace competitiveprogramming.leetcode
{
    public class LC_988
    {
        
        public string SmallestFromLeaf(TreeNode root)
        {
            return dfs(root, new List<char>());
        }

        public string dfs(TreeNode curr, List<Char> word)
        {
            word.Insert(0, (char)(curr.val + 97));
            String smallest = "{";
            if (curr.left == null && curr.right == null)
            {
                // -1 is less, 0 is same, 1 is more
                int comp = String.CompareOrdinal(new string(word.ToArray()), smallest);
                if (comp < 0)
                {
                    smallest = new string(word.ToArray());
                }
            }
            if (curr.left != null)
            {
                string wordLeft = dfs(curr.left, word);
                int comp = String.CompareOrdinal(wordLeft, smallest);
                if (comp < 0)
                {
                    smallest = wordLeft;
                }
            }
            if (curr.right != null)
            {
                string wordRight = dfs(curr.right, word);
                int comp = String.CompareOrdinal(wordRight, smallest);
                if (comp < 0)
                {
                    smallest = wordRight;
                }
            }
            
            word.RemoveAt(0);
            return smallest;
        }
       
        
    }


}

