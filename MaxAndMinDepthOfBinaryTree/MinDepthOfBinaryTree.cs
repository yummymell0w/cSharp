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
                return -1;
            }
            if (node.left == null && node.right == null)
            {
                return 1;
            }

            int? lt = CountNodes(node.left);
            int? rt = CountNodes(node.right);

            int l = lt == -1 ? Int32.MaxValue : (int)lt;
            int r = rt == -1 ? Int32.MaxValue : (int)rt;

            return Math.Min((int)l, (int)r) + 1;
        }
    }
}
