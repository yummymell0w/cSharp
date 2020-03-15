using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problems
{
    public class Visa
    {
        public static int filledOrders(List<int> order, int k)
        {
            int filled = 0;
            int i = 1;

            while (i < order.Count && k>0)
            {
                if (order[i] <= k)
                {
                    k = k - order[i];
                    filled++;
                    i++;
                }

            }
            return filled;
        }
    }
}

