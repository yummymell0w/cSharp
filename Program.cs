using System;

namespace Problems
{
    public class Program
    {
        static public void Main(string[] args)
        {
            string ipAddress = "255.100.50.0";
            DefangingIpAddress object1 = new DefangingIpAddress();
            Console.WriteLine(object1.DefangIPaddr(ipAddress));

            string J = "aA";
            string S = "aAAbbbb";
            JewelsAndStones object2 = new JewelsAndStones();
            Console.WriteLine(object2.NumJewelsInStones(S, J));

            int[] A = { 1, 2, 3, 3 };
            NRepeatedElement object3 = new NRepeatedElement();
            Console.WriteLine(object3.RepeatedNTimes(A));

            int left = 1;
            int right = 2;
            SelfDividingNumbers object4 = new SelfDividingNumbers();
            Console.WriteLine(object4.SelfDividingNumber(left, right));

            string keyboard = "abcdefghijklmnopqrstuvwxyz";
            string word = "cba";
            SingleRowKeyboard object5 = new SingleRowKeyboard();
            Console.WriteLine(object5.CalculateTime(keyboard, word));

            int[] B = { 3, 1, 2, 4 };
            SortArrayByParity object6 = new SortArrayByParity();
            Console.WriteLine(object6.SortArray(B));

            int[] C = { 3, 1, 2, 4 };
            SortArrayByParityViaList object7 = new SortArrayByParityViaList();
            Console.WriteLine(object7.SortArrayByParityList(C));

            string D = "RLRRLLRLRL";
            SplitBalancedString object8 = new SplitBalancedString();
            Console.WriteLine(object8.BalancedStringSplit(D));

            int[] E = { -4, -1, 0, 3, 10 };
            SquaresOfSortedArray object9 = new SquaresOfSortedArray();
            Console.WriteLine(object9.SortedSquares(E));

            string str = "Hello";
            ToLowerCase object10 = new ToLowerCase();
            Console.WriteLine(object10.ConvertToLowerCase(str));

            string[] words = { "gin", "zen", "gig", "msg" };
            UniqueMorseCodeWords object11 = new UniqueMorseCodeWords();
            Console.WriteLine(object11.ConvertAllWordsToMorseCode(words));

            int[] arr = { 1, 2, 2, 1, 1, 3 };
            UniqueNumberOccurrences object12 = new UniqueNumberOccurrences();
            Console.WriteLine(object12.UniqueOccurrences(arr));
        }
    }
}


