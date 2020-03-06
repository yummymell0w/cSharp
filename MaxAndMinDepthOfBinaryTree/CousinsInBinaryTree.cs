using System;
using System.Collections.Generic;
using System.Text;

namespace Problems.MaxAndMinDepthOfBinaryTree
{
    class CousinsInBinaryTree
    {
        public static bool IsCousins(TreeNode root, int x, int y)
        {
            if (root == null)
            {
                return false;
            }

            if (root.left == null && root.right == null)
            {
                return false;
            }

            int level = 1;
            int levelX = 0;
            int levelY = 0;
            int parentX = 0;
            int parentY = 0;

            Queue<TreeNode> searchQueue = new Queue<TreeNode>();
            searchQueue.Enqueue(root);


            Queue<TreeNode> nodesQueue;

            do
            {
                nodesQueue = new Queue<TreeNode>();
                level++;


                while (searchQueue.Count > 0)
                {
                    var node = searchQueue.Dequeue();

                    if ((node.left != null && node.left.val == x) || (node.right != null && node.right.val == x))
                    {
                        levelX = level;
                        parentX = node.val;
                    }


                    if ((node.left != null && node.left.val == y) || (node.right != null && node.right.val == y))
                    {
                        levelY = level;
                        parentY = node.val;
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

                if (levelX > 0 || levelY >0)
                {
                    break;
                }

                searchQueue = nodesQueue;

            } while (nodesQueue.Count > 0);

            return (levelX == levelY && parentX != parentY);
        }
    }
}
