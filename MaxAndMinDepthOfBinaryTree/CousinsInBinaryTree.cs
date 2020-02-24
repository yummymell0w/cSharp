using System;
using System.Collections.Generic;
using System.Text;

namespace Problems.MaxAndMinDepthOfBinaryTree
{
    class CousinsInBinaryTree
    {
        public bool IsCousins(TreeNode root, int x, int y)
        {
            // if root vals are not equal
            //and child nodes are on the same level
            //return true

            if (root == null)
            {
                return false;
            }

            int level = 0;
            int levelX = 0;
            int levelY = 0;
            int parentX = 0;
            int parentY = 0;

            Queue<TreeNode> searchQueue =new Queue<TreeNode>();
            searchQueue.Enqueue(root);


            Queue<TreeNode> nodesQueue;

            do
            {
                nodesQueue = new Queue<TreeNode>();
                level++;
                

                while (searchQueue.Count > 0)
                {
                    var node = searchQueue.Dequeue();

                    if (node.left.val == x || node.left.val == y)
                    {
                        levelX = level;
                        parentX = node.val;

                    }
                    else
                    {
                        nodesQueue.Enqueue(node.left);

                    }

                    if (node.right.val == x || node.right.val == y)
                    {
                        levelY = level;
                        parentY = node.val;
                    }
                    else
                    {
                        nodesQueue.Enqueue(node.right);
                    }

                }

            } while (nodesQueue.Count > 0);
            // compare levels and parents
            return (levelX == levelY && parentX != parentY);

        }
    }
}
