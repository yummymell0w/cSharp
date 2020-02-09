using System;
using System.Collections.Generic;
using System.Text;

namespace Problems.MaxAndMinDepthOfBinaryTree
{
    class MaxDepthOfBinaryTree
    {
        public static int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            return CountNodes(root);
        }

        public static int CountNodes(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            int max = 0;

            max = Math.Max(CountNodes(root.left), max);
            max = Math.Max(CountNodes(root.right), max);

            return max + 1;
        }
    }
}
