using System;
using System.Collections.Generic;
using System.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Problems.Leetcode_30_days
{
    public class Day2HappyNumber
    {
        public static bool IsHappy(int n)
        {
            if (n == 0)
            {
                return false;
            }

            List<int> sums = new List<int>();

            while (SumOfDoubleDigits(ConvertNumberToArray(n)) != 1)
            {
                if(sums.Contains(SumOfDoubleDigits(ConvertNumberToArray(n))))
                {
                    return false;
                }
                else
                {
                    sums.Add(SumOfDoubleDigits(ConvertNumberToArray(n)));
                    n = SumOfDoubleDigits(ConvertNumberToArray(n));
                }
            }

            return true;
        }

        public static int[] ConvertNumberToArray(int n)
        {
            var digits = new List<int>();

            for (; n != 0; n /= 10)
            {
                digits.Add(n % 10);
            }

            var arr = digits.ToArray();
            Array.Reverse(arr);

            return arr;
        }

        public static int SumOfDoubleDigits(int[] arr)
        {
            int sum = 0;
            foreach (int digit in arr)
            {
                int doubleN = (int)Math.Pow(digit, 2);
                sum += doubleN;
            }

            return sum;
        }
    }
}
