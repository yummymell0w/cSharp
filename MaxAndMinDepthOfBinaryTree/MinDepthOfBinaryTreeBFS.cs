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

            Queue<TreeNode> searchQueue = new Queue<TreeNode>();
            searchQueue.Enqueue(root);

            Queue<TreeNode> nodesQueue;

            int depth = 0;

            do
            {
                nodesQueue = new Queue<TreeNode>();
                depth++;
                while (searchQueue.Count > 0)
                {
                    var node = searchQueue.Dequeue();

                    if (node.right == null && node.left == null)
                    {
                        return depth;
                    }

                    if (node.left != null)
                    {
                        nodesQueue.Enqueue(node.left);
                    }

                    if (node.right != null)
                    {
                        nodesQueue.Enqueue(node.right);
                    }
                }

                searchQueue = nodesQueue;

            } while (nodesQueue.Count > 0);

            return depth;
        }

    }
}
