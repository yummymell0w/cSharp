using System.Collections.Generic;
using System;
public class RelativeSortArray
{
    public static int[] RelativeSort(int[] arr1, int[] arr2)
    {
        //Input: arr1 = [2,3,1,3,2,4,6,7,9,2,19], 
        //arr2 = [2,1,4,3,9,6]
        //Output: [2,2,2,1,4,3,3,9,6,7,19]

     
        List<int> match = new List<int>();
        List<int> noMatch = new List<int>();

        for (int i = 0; i < arr2.Length; i++)
        {
            for (int j = 0; j < arr1.Length; j++)
            {
                if (arr2[i] == arr1[j])
                {
                    match.Add(arr1[j]);
                }
                else
                {
                    noMatch.Add(arr1[j]);
                }
            }
        }

        int[] result = new int[arr1.Length];
        Array.Copy(match.ToArray(), result, match.Count);
        Array.Copy(noMatch.ToArray(), 0, result, match.Count, noMatch.Count);

        return result;
    }
}