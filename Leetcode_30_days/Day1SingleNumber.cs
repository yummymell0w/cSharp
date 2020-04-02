using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Problems.Leetcode_30_days
{
    public class Day1SingleNumber
    {
        public static int SingleNumber(int[] nums)
        {
            //Input: [4, 1, 2, 1, 2]
            //Output: 4

            Array.Sort(nums);
            int result;

            for (int i = 0; i < nums.Length-1; i+=2)
            {
                if (nums[i] != nums[i + 1])
                {
                    result = nums[i];
                    return result;
                }
            }

            return nums[nums.Length-1];
        }
    }
}
