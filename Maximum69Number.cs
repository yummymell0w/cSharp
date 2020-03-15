using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Problems
{
    public class Maximum69Number
    {
        public static int Max69Number(int num)
        {
            // Input: num = 9669
            //Output: 9969

            char[] nums= num.ToString().ToCharArray();
            int[] numbers =new int[nums.Length];

            int max = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == '6')
                {
                    numbers[i] = 6;
                }
                else
                {
                    numbers[i] = 9;
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (numbers[i] == 6)
                {
                    numbers[i] = 9;
                    break;
                }
            }

            for (int i = numbers.Length -1 ; i >=0; i--)
            {
                max += numbers[numbers.Length-1-i] * (int)Math.Pow(10, i);
            }

            return max;
        }
    }
}
