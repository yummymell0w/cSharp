public class FindSpecificElement
{
    public static int FindSpecialInteger(int[] arr)
    {
        //int[] arr = {1,2,2,6,6,6,6,7,10};
        int quarter = arr.Length / 4;
        int number = arr[0];
        int counter = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == number)
            {
                counter++;
            }
            else
            {
                number = arr[i];
                counter = 1;
            }
            if (counter > quarter)
            {
                return number;
            }
        }
        return number;
    }
}