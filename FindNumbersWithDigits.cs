using System;
using System.Collections.Generic;

namespace Problems
{
    public class FindNumbersWithDigits
    {
        public static int FindNumbers(int[] nums)
        {
            int counter = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if ((nums[i] > 9 && nums[i] < 100) || (nums[i] > 999 && nums[i] < 10000))
                {
                    counter++;
                }
            }
            return counter;
        }
    }
    /*public static int FindNumbers1(int[] nums)
            {
                int counter = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    int c = 0;
                    for (int x =nums[i]; x > 0; x /= 10)
                    {
                        c++;
                    }
                    if ((c%2) == 0)
                    {
                        counter++;
                    }          
                }
                return counter;
            }
        }
        */
}