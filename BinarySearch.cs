public class BinarySearch
{
    public static int Search(int[] nums, int target)
    {
        //Input: 
        //nums = [-1,0,3,5,9,12]
        //target = 9

        int indexLowest = 0;
        int indexHighest = nums.Length - 1;

        if (nums.Length == 1)
        {
            if (nums[0] == target)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

        while (indexLowest <= indexHighest)
        {
            int indexMiddle = (indexLowest + indexHighest) / 2;
            int guess = nums[indexMiddle];
            if (target == guess)
            {
                return indexMiddle;
            }
            if (guess > target)
            {
                indexHighest = indexMiddle - 1;
            }
            else
            {
                indexLowest = indexMiddle + 1;
            }
        }
        return -1;
    }
}