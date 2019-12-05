using System;
using System.Collections.Generic;

namespace Problems
{
    public class SortArrayByParityViaList
    {
        // Sort array by parity via List
        public int[] SortArrayByParityList(int[] A)
        {
            List<int> B = new List<int>();
            List<int> C = new List<int>();
            int j = 0;
            int k = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 0)
                {
                    B.Add(A[i]);
                    j++;
                }
                else
                {
                    C.Add(A[i]);
                    k++;
                }
            }

            List<int> D = new List<int>();
            D.AddRange(B);
            D.AddRange(C);
            int[] E = D.ToArray();
            return E;
        }
    }
}