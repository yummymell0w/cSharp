using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Problems.Leetcode_30_days
{
    public class Day3MaximumSubArray
    {
        public static int MaxSubArray(int[] nums, int l, int h)
        {
            int pivot = nums[nums.Length / 2];

            if (nums.Length == 1)
            {
                return nums[0];
            }

            return Math.Max(Math.Max(MaxSubArray(nums, nums[0], pivot - 1), MaxSubArray(nums, pivot, nums[nums.Length - 1])), LeftRightSum(nums, pivot));
        }

        public static int LeftRightSum(int[] nums, int pivot)
        {


            int sum = 0;
            int leftSum = int.MinValue;

            for (int i = pivot - 1; i >= 0; i--)
            {
                sum += nums[i];
                if (sum > leftSum)
                {
                    leftSum = sum;
                }
            }

            sum = 0;
            int rightSum = int.MinValue;
            for (int i = pivot; i < nums.Length; i++)
            {
                sum += nums[i];
                if (sum > rightSum)
                {
                    rightSum = sum;
                }
            }
            return leftSum + rightSum;
        }
    }
}
