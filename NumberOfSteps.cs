using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace Problems
{
    public class NumberOfSteps
    {
        public static int NumberSteps(int num)
        {
            /*Input: num = 14
            Output: 6
            Explanation:
            Step 1) 14 is even; divide by 2 and obtain 7.
                Step 2) 7 is odd; subtract 1 and obtain 6.
                */

            if (num == 0)
            {
                return 0;
            }

            int steps = 0;

            while (num > 0)
            {
                if (num % 2 == 0)
                {
                    num = num / 2;
                    steps++;
                }
                else
                {
                    num = num - 1;
                    steps++;
                }
            }

            return steps;
        }
    }
}
