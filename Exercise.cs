using System;
using System.Collections.Generic;
using System.Linq;

//recursion and quicksort exercises
public class Exercise
{
    public static int sum(int[] arr)
    {
        if (arr.Length == 0)
        {
            return 0;
        }

        return arr[0] + arr.Skip(1).ToArray().Sum();

    }


    public static int numberOfItems(List<int> items)
    {
        if (items.Count == 0)
        {
            return 0;
        }
        return 1 + items.Skip(1).Count();
    }

    // sort array via quicksort
    public static int[] quickSort(int[] unsorted)
    {
        if (unsorted.Length < 2)
        {
            return unsorted;
        }
        else
        {
            int pivot = unsorted[0];
            List<int> less = new List<int>();
            List<int> greater = new List<int>();
            for(int i = 1; i<unsorted.Length; i++)
            {
                if (unsorted[i] <= pivot)
                {
                    less.Add(unsorted[i]);
                }
                else
                {
                    greater.Add(unsorted[i]);
                }
            }


            // concatenate quicksort(less), pivot and quicksort(greater)
            int[] result = new int[unsorted.Length];

            int[] lessArr = less.ToArray();
            int[] greaterArr = greater.ToArray();

            lessArr = quickSort(lessArr);
            greaterArr = quickSort(greaterArr);

            Array.Copy(lessArr,result,lessArr.Length);
            result[lessArr.Length] = pivot;
            Array.Copy(greaterArr, 0, result, lessArr.Length+1,greaterArr.Length);

            return result;
        }
    }

}

