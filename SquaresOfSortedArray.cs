using System;

namespace Problems
{
    public class SquaresOfSortedArray
    {
        // Squares of a Sorted Array v1
        public static int[] SortedSquares(int[] A)
        {
            int[] squares = new int[A.Length];
            for (int x = 0; x < A.Length; x++)
            {
                squares[x] = (int)Math.Pow(A[x], 2);
            }

            Array.Sort(squares);

            return squares;
        }

        /*
        // Squares of a Sorted Array v2
        public static int[] SortedSquares(int[] A)
        {
            int[] squares = new int[A.Length];
            int i = 0;
            int j = A.Length - 1;
            for (int index = A.Length - 1; index >= 0; index--)
            {
                var leftNumber = A[i] * A[i];
                var rightNumber = A[j] * A[j];
                if (leftNumber < rightNumber)
                {
                    squares[index] = rightNumber;
                    j--;
                }
                else
                {
                    squares[index] = leftNumber;
                    i++;
                }
            }
            return squares;
        }
        */
    }
}