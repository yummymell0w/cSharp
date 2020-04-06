using System;
using System.Collections.Generic;
using System.Text;

namespace Problems.Leetcode_30_days
{
    class Day5BestTimeToBuyStocks
    {
        public static int MaxProfit(int[] prices)
        {
            int total = 0;

            for (int i = 0; i < prices.Length-1; i++)
            {
                int diff = prices[i + 1] - prices[i];
                if (diff > 0)
                {
                    total += diff;
                }
            }

            return total;
        }
    }
}
