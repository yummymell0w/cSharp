using System;
using System.Collections.Generic;
using System.Linq;
public class StudentHeights
{
    public static int FindSmallest(int[] heights)
    {
        int smallest = heights[0];
        int index = 0;
        for (int i = 1; i < heights.Length; i++)
        {
            if (heights[i] < smallest)
            {
                smallest = heights[i];
                index = i;
            }
        }
        return index;
    }

    public static int HeightChecker(int[] heights)
    {
        int[] sortedHeights = new int[heights.Length];
        int[] copyHeights = new int[heights.Length];
        heights.CopyTo(copyHeights, 0);
        int result = 0;
        int smallestIndex = 0;

        for (int i = 0; i < copyHeights.Length; i++)
        {
            smallestIndex = FindSmallest(copyHeights);
            sortedHeights[i] = copyHeights[smallestIndex];
            copyHeights[smallestIndex] = Int32.MaxValue;

        }

        //count how many elements were moved

        for (int i = 0; i < heights.Length; i++)
        {
            if (heights[i] != sortedHeights[i])
            {
                result++;
            }
        }
        return result;
    }
}