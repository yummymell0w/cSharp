using System;
using System.Linq;
using System.Collections.Generic;

public class SubtractProductAndSum
{
    public static int SubtractProduct(int n)
    {
        List<int> listOfNumbers = new List<int>();
        for (; n>0; n/=10)
        {
        listOfNumbers.Add(n % 10);
        }

        int[] numbers = listOfNumbers.ToArray();

        int product = 1;
        int sum = 0; 
        foreach(int x in numbers)
        {
            product *= x;
        } 
        foreach (int y in numbers)
        {
            sum += y;
        }
        int result = product - sum;
        return result;
    }
}