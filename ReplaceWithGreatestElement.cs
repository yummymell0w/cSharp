public class ReplaceWithGreatestElement
{
    public static int[] ReplaceElements(int[] arr)
    {
        //Input: arr = [17,18,5,4,6,1]
        //Output: [18,6,6,6,1,-1]

        int[] sortedArr = new int[arr.Length];
        int max = 1;
        for (int i = arr.Length - 2; i >= 0; i--)
        {
            if (max < arr[i + 1])
            {
                max = arr[i + 1];
            }
            sortedArr[i] = max;
        }
        sortedArr[arr.Length - 1] = -1;
        return sortedArr;
    }
}