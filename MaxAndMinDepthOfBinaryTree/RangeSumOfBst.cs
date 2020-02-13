using System;
using System.Collections.Generic;
using System.Text;

namespace Problems.MaxAndMinDepthOfBinaryTree
{
    class RangeSumOfBst
    {
        public int RangeSumBST(TreeNode root, int L, int R)
        {
            //Input: root = [10, 5, 15, 3, 7, null, 18],
            //L = 7,
            //R = 15

            if (root == null)
            {
                return 0;
            }

            var sum = 0;
            if (L <= root.val && root.val <= R)
            {
                sum = root.val;
            }

            var left = RangeSumBST(root.left, L, R);
            var right = RangeSumBST(root.right, L, R);

            return left + right + sum;
        }
    }
}
