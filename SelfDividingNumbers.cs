using System;
using System.Collections.Generic;

namespace Problems
{
    public class SelfDividingNumbers
    {
        public static List<int> SelfDividingNumber(int left, int right)
        {
            List<int> selfNumbers = new List<int>();
            for (int i = left; i <= right; i++)
            {
                if (isSelfDividing(i))
                {
                    selfNumbers.Add(i);
                }
            }
            return selfNumbers;
        }

        public static bool isSelfDividing(int i)
        {
            char[] range = i.ToString().ToCharArray();
            foreach (char element in range)
            {
                if ((element == '0') || (i % (element - '0') != 0))
                {
                    return false;
                }
            }
            return true;
        }
    }
}