using System.Collections.Generic;
using System;
using System.Linq;
public class RelativeSortArray
{
    public static int[] RelativeSort(int[] arr1, int[] arr2)
    {
        HashSet<int> array2 = new HashSet<int>(arr2);
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
            }
        }

        foreach (var number in arr1)
        {
            if (!array2.Contains(number))
            {
                noMatch.Add(number);
            }
        }

        noMatch.Sort();
        int[] result = new int[arr1.Length];
        Array.Copy(match.ToArray(), result, match.Count);
        Array.Copy(noMatch.ToArray(), 0, result, match.Count, noMatch.Count);
        return result;
    }
}