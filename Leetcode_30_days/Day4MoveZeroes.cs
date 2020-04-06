using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problems.Leetcode_30_days
{
    public class Day4MoveZeroes
    {
        public static int[] MoveZeroes(int[] nums)
        {

            int k = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                
                if (nums[i] != 0)
                {
                    nums[k] = nums[i];
                    k++;
                }
            }

            for (int i = k; i < nums.Length; i++)
            {
                nums[i] = 0;
            }

            return nums;
        }
    }
}
