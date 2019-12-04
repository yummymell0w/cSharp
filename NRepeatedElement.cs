using System;
using System.Collections.Generic;

public class NRepeatedElement
{
    public static int RepeatedNTimes(int[] A)
    {
        Dictionary<int, int> inputDigits = new Dictionary<int, int>();
        int numberN = 0;
        for (int i = 0; i < A.Length; i++)
        {
            if (!inputDigits.ContainsKey(A[i]))
            {
                inputDigits.Add(A[i], i);
            }
            else
            {
                numberN = A[i];
                break;
            }
        }
        return numberN;
    }
}