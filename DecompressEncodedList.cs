using System;
using System.Collections.Generic;
using System.Security;
using System.Text;
using Microsoft.VisualBasic;

namespace Problems
{
    public class DecompressEncodedList
    {
        public static int[] DecompressRLElist(int[] nums)
        {
            List<int> resultList = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (i % 2 != 0)
                {
                    while (nums[i - 1] > 0)
                    {
                        resultList.Add(nums[i]);
                        nums[i - 1]--;
                    }
                }
            }

            int[] result = resultList.ToArray();
            return result;
        }
    }
}
