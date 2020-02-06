using Problems.MaxDepthOfBinaryTree;
using System;

namespace Problems.MaxAndMinDepthOfBinaryTree
{
    class MinDepthOfBinaryTree
    {
        public static int MinDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }


            return CountNodes(root);
        }

        public static int CountNodes(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }

            int min = Int32.MaxValue;

            min = Math.Min(CountNodes(node.left), min);
            min = Math.Min(CountNodes(node.right), min);
            return min+1;
        }
    }
}
