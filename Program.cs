﻿using System;
using System.Collections.Generic; 



class Program
{
    /*
    public int CompareOneJewelToStones(char jewel, string S)
    {
        char[] stones = S.ToCharArray();
        int myJewels = 0;
        int i = 0;
        while (i < stones.Length)
        {
            if (jewel == stones[i])
                myJewels++;
            i++;

        }
        return myJewels;
    }
    public int NumJewelsInStones(string J, string S)
    {
        char[] jewels = J.ToCharArray();
        int myJewels = 0;
        int i = 0;
        while (i < jewels.Length)
        {
            int result = CompareOneJewelToStones(jewels[i], S);
            myJewels = myJewels + result;
            i++;

        }
        return myJewels;

    }


    public static int NumJewelsInStones(string J, string S)
    {
        char[] stones = S.ToCharArray();
        char[] jewels = J.ToCharArray();
        int myJewels = 0;
        int i = 0;
        while (i < S.Length)
        {
            foreach (char jewel in jewels)
            {
                if (jewel == stones[i])
                    myJewels++;

            }
            i++;
        }
        return myJewels;
    }

     Single row keyboard problem:

    public static int CalculateTime(string keyboard, string word)
    {
        char[] alphabet = keyboard.ToCharArray();
        char[] input = word.ToCharArray();
        int i = 0;
        int index = 0;

        while (i < alphabet.Length)
        {foreach (char letter in input){

            if (input[i] == alphabet[i])
            {
                index = Array.IndexOf(alphabet, alphabet[i]);

            }
            }
            i++;

        }
        return index;
    }
    */

    /*public static int[] SortArrayByParity(int[] A)
    {
        int[] B = new int[A.Length];
        int[] C = new int[A.Length];
        int j = 0;
        int k = 0;

        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] % 2 == 0)
            {
                // create array with even numbers
                B[j] = A[i];
                j++;
            }else{
                // create array with odd number
                C[k] = A[i];
                k++;
            }
        }
        // concatinate 2 arrays

        int[] D = new int[A.Length];
        for (int i = 0; i < j; i++)
        {
            D[i] = B[i];
        }

        for (int i = 0; i < k; i++)
        {
            D[j+i] = C[i];
        }


        // return new array
        return D;
    }*/

    // Sort array by parity via List
    public static int[] SortArrayByParity(int[] A)
    {
        List<int> B = new List<int>();
        List<int> C = new List<int>();
        int j = 0;
        int k = 0;

        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] % 2 == 0)
            {
                // create list with even numbers
               
                B.Add(A[i]);
                j++;
            }
            else
            {
                // create list with odd number
            
                C.Add(A[i]);
                k++;
            }
        }


        // concatinate 2 lists
        List<int> D = new List<int>();
        D.AddRange(B);
        D.AddRange(C);
        int[] E = D.ToArray();

        // return new array
        return E;
    }

    static public void Main(string[] args)
    {
        int[] A = { 3, 1, 2, 4, 5, 4, 8, 6, 2 };
        int[] result = SortArrayByParity(A);

        for (int i = 0; i < result.Length; i++)
        {
            Console.Write(result[i] + ",");
        }

    }
}




