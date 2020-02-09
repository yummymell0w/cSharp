using System;
using System.Collections.Generic;
using System.Text;

namespace Problems.MaxAndMinDepthOfBinaryTree
{
    class MaxDepthOfBinaryTreeBfs
    {
        public static int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            Queue<TreeNode> searchQueue = new Queue<TreeNode>();
            searchQueue.Enqueue(root);

            Queue<TreeNode> nodesQueue;

            int nodeCount = 0;

            do
            {
                nodesQueue = new Queue<TreeNode>();
                nodeCount++;

                while (searchQueue.Count > 0)
                {
                    var node = searchQueue.Dequeue();

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

            return nodeCount;
        }


    }
}
