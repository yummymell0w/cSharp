using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Problems
{
    public class HowManyNumbersAreSmaller
    {
        public static int[] SmallerNumbersThanCurrent(int[] nums)
        {
            int[] result = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                int more = 0;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        more++;
                    }
                }

                result[i] = more;
            }

            return result;
        }
    }
}
