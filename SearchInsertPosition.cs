using System;
public class SearchInsertPosition
{
    public static int SearchInsert(int[] nums, int target)
    {
        int min = 0;
        int max = nums.Length - 1;
        

        if (nums.Length == 1)
        {
            if (nums[0] == target)
            {
                return 0;
            }
            else
            {
                return returnPosition(nums, target);
            }
        }

        while (min <= max)
        {   
            int middle = (min + max) / 2;
            int guess = nums[middle];
            if (guess == target)
            {
                return middle;
            }
            if (guess > target)
            {
                max = middle - 1;
            }
            else
            {
                min = middle + 1;
            }
        }

        return returnPosition(nums, target);

    }

    public static int returnPosition(int[] nums, int target)
    {
        int[] newNums = new int[nums.Length + 1];
        newNums[0] = target;
        nums.CopyTo(newNums, 1);
        Array.Sort(newNums);
        int index = Array.IndexOf(newNums, target);
        return index;
    }
}