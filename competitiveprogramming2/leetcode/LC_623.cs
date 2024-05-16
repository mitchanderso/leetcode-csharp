
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace competitiveprogramming.leetcode
{
    public class LC_623
    {
        
        public TreeNode AddOneRow(TreeNode root, int val, int depth) {
            // For now ignore case when depth is 1
            var currentDepth = 1;
            Queue<TreeNode> nodes = new Queue<TreeNode>();
            nodes.Enqueue(root);

            if (depth == 1)
            {
                var newRoot = new TreeNode(val, root, null);
                return newRoot;
            }

            while (nodes.Count > 0)
            {
                var levelNodes = nodes.Count;
                for (int i = 0; i < levelNodes; i++)
                {
                    var currentNode = nodes.Dequeue();
                    if (currentDepth == depth - 1)
                    {
                        var oldLeft = currentNode.left;
                        var oldRight = currentNode.right;
                        var newLeft = new TreeNode(val, oldLeft, null);
                        var newRight = new TreeNode(val, null, oldRight);
                        currentNode.left = newLeft;
                        currentNode.right = newRight;
                    }
                    if (currentNode.left != null) nodes.Enqueue(currentNode.left);
                    if (currentNode.right != null) nodes.Enqueue(currentNode.right);
                }

                currentDepth++;
            }

            return root;
        }
       
       
        
    }


}

