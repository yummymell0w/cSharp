using System;
using System.Collections;
using System.Collections.Generic;

namespace Problems.MaxAndMinDepthOfBinaryTree
{
    class MinDepthOfBinaryTreeBfs
    {
        public static int MinDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            if (root.right == null && root.left == null)
            {
                return 1;
            }

            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);


            int depth = Int32.MaxValue;

            while (stack.Count > 0)
            {


            }
        }

    }
}
