using System;
using System.Linq;
using System.Collections.Generic;

public class SubtractProductAndSum
{
    public int SubtractProduct(int n)
    {
        List<int> listOfNumbers = new List<int>();
        for (; n>0; n/=10)
        {
        listOfNumbers.Add(n % 10);
        }

        int[] numbers = listOfNumbers.ToArray();

        int product = 1;
        int sum = 0;
        // Product of digits = 2 * 3 * 4 = 24 
        foreach(int x in numbers)
        {
            product *= x;
        }
        //Sum of digits = 2 + 3 + 4 = 9 
        foreach (int y in numbers)
        {
            sum += y;
        }
        //Result = 24 - 9 = 15
        int result = product - sum;
        return result;

    }
}