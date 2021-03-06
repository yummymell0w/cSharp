using System.Collections.Generic;

namespace Problems
{
    public class SortArrayByParityViaList
    {
        public static int[] SortArrayByParityList(int[] A)
        {
            List<int> B = new List<int>();
            List<int> C = new List<int>();
            
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 0)
                {
                    B.Add(A[i]);
                }
                else
                {
                    C.Add(A[i]);
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