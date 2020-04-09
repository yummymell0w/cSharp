using System;
using System.Collections.Generic;
using System.Text;

namespace Problems.Leetcode_30_days
{
    public class Day7CountingElelments
    {
        //Input: arr = [1,3,2,3,5,0]
        // Output: 3

        public static int CountElements(int[] arr)
        {
            int counter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] - arr[i] == 1)
                    {
                        counter++;
                        break;
                    }
                }
            }

            return counter;
        }

    }
}
