using System;
using System.Collections.Generic;
using System.Text;

namespace Problems.MaxAndMinDepthOfBinaryTree
{
    class UnivaluedBinaryTree
    {
        public bool IsUnivalTree(TreeNode root)
        {
            //Input: [1,1,1,1,1,null,1]
            //Output: true

            if (root == null)
            {
                return true;
            }

            if (!Compare(root))
            {
                return false;
            }

            var left = IsUnivalTree(root.left); 
            var right = IsUnivalTree(root.right);

            if (!left || !right)
            {
                return false;
            }

            return true;
        }

        public bool Compare(TreeNode root)
        {

                if ((root.right == null || root.val == root.right.val) && 
                    (root.left == null || root.val == root.left.val))
                {
                    return true;
                } 
                return false;
        }

    }
}
