
using System;
using System.Collections.Generic;
using System.Linq;

namespace competitiveprogramming.leetcode
{
    
    
    public class LC_110
    {
        int UNBALANCED = -1;
        public bool IsBalanced(TreeNode root)
        {
            if (root == null) return true;
            if (height(root) != -1) return true;
            return false;
        }

        public int height(TreeNode root)
        {
            if (root == null) return 0;
            var leftHeight = height(root.left);
            if (leftHeight == UNBALANCED) return UNBALANCED;
            var rightHeight = height(root.right);
            if (rightHeight == UNBALANCED) return UNBALANCED;
            var diff = Math.Abs(leftHeight - rightHeight);
            if (diff > 1) return UNBALANCED;
            return 1 + Math.Max(leftHeight, rightHeight);


        }
        
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}

