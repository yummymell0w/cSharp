using System;
using System.Collections.Generic;

namespace Problems
{
    public class Program
    {
        static public void Main(string[] args)
        {
            int[] nums = { 437, 315, 322, 431, 686, 264, 442 };
            Console.WriteLine(FindNumbersWithDigits.FindNumbers(nums));

            int n = 234;
            Console.WriteLine(SubtractProductAndSum.SubtractProduct(n));

            string ipAddress = "255.100.50.0";
            Console.WriteLine(DefangingIpAddress.DefangIPaddr(ipAddress));

            string J = "aA";
            string S = "aAAbbbb";
            Console.WriteLine(JewelsAndStones.NumJewelsInStones(S, J));

            int[] A = { 1, 2, 3, 3 };
            Console.WriteLine(NRepeatedElement.RepeatedNTimes(A));

            int left = 1;
            int right = 4;
            List<int> testList = SelfDividingNumbers.SelfDividingNumber(left, right);
            foreach(int i in testList)
            {
            Console.WriteLine(i);
            }

            int[] B = { 3, 1, 2, 4 };
            int[] testArray = SortArrayByParity.SortArray(B);
            foreach(var i in testArray)
            {
            Console.WriteLine(i);
            }

            int[] C = { 3, 1, 2, 4 };
            int[] testArray2 = SortArrayByParityViaList.SortArrayByParityList(C);
            foreach(var i in testArray2)
            {
            Console.WriteLine(i);
            }

            string D = "RLRRLLRLRL";
            Console.WriteLine(SplitBalancedString.BalancedStringSplit(D));

            int[] E = { -4, -1, 0, 3, 10 };
            int[] testArray3 = SquaresOfSortedArray.SortedSquares(E);
            foreach(var i in testArray3)
            {
            Console.WriteLine(i);
            }

            string str = "Hello";
            Console.WriteLine(ToLowerCase.ConvertToLowerCase(str));

            string[] words = { "gin", "zen", "gig", "msg" };
            HashSet<string> testSet = UniqueMorseCodeWords.ConvertAllWordsToMorseCode(words);
            foreach(var i in testSet)
            {
            Console.WriteLine(i);
            }

            int[] arr = { 1, 2, 2, 1, 1, 3 };
            Dictionary<int, int> testMap = UniqueNumberOccurrences.UniqueOccurrences(arr);
            foreach(KeyValuePair<int, int> i in testMap)
            {
            Console.WriteLine(i.Value);
            }
        }
    }
}


