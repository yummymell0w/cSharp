using System;

namespace Problems
{
    public class SortArrayByParity
    {
        public int[] SortArray(int[] A)
        {
            int[] B = new int[A.Length];
            int[] C = new int[A.Length];
            int j = 0;
            int k = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 0)
                {
                    B[j] = A[i];
                    j++;
                }
                else
                {
                    C[k] = A[i];
                    k++;
                }
            }

            int[] D = new int[A.Length];
            for (int i = 0; i < j; i++)
            {
                D[i] = B[i];
            }

            for (int i = 0; i < k; i++)
            {
                D[j + i] = C[i];
            }
            return D;
        }
    }
}