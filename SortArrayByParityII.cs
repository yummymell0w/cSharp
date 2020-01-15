using System.Collections.Generic;

public class SortArrayByParityII
{
    public static int[] SortArrayByParity(int[] A)
    {
        int[] result = new int[A.Length];
        int evenIndex = 0;
        int oddIndex = 1;

        if (A.Length == 2)
        {
            if (A[0] % 2 == 0)
            { return A; }
            else
            {
                int j = A[0];
                A[0] = A[1];
                A[1] = j;
                return A;
            }
        }

        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] % 2 == 0)
            {
                result[evenIndex] = A[i];
                evenIndex += 2;
            }
            else
            {
                result[oddIndex] = A[i];
                oddIndex += 2;
            }
        }
        return result;

    }
}