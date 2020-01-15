using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems
{
    public class Program
    {
        static public void Main(string[] args)
        {
            
            int[] A = {3,1,4,2};
            printIntList(SortArrayByParityII.SortArrayByParity(A).ToList());

            /*int[] arr = { 2, 4, 6 };
            //int[] unsorted = { 3, 2, 6, 8, 9, 44, 1 };
            int[] unsorted = {};
            List<int> letters = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine(Exercise.sum(arr));
            Console.WriteLine(Exercise.numberOfItems(letters));
            printIntList(Exercise.quickSort(unsorted).ToList());


            /*int[] arr = {17,18,5,4,6,1};
            int[] results =ReplaceWithGreatestElement.ReplaceElements(arr);
            printIntList(results.ToList());
            
            //string word = "a";
            //printDictionaryChar(FindCommonCharacters.toDictionary(word));

            string[] A = {"bella","label","roller"};
            printList(FindCommonCharacters.CommonChars(A));

            /*
            int[] nums = {1,3,5,6};
            int target = 2;
            Console.WriteLine(SearchInsertPosition.SearchInsert(nums, target)); 

            
            int[] nums = {2,5};
            int target = 0;
            Console.WriteLine(BinarySearch.Search(nums, target));
    
            /*
            int[] arr = {1,2,2,6,6,6,6,7,10};
            Console.WriteLine(FindSpecificElement.FindSpecialInteger(arr));

            
            int[] heights = {1,2,1,2,1,1,1,2,1};
            Console.WriteLine(StudentHeights.HeightChecker(heights));

            
            string S = "a1b2";
            printList(LetterCasePermutation.LetterPermutation(S));

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
            printList(testList);

            int[] B = { 3, 1, 2, 4 };
            int[] testArray = SortArrayByParity.SortArray(B);
            printList(testArray.ToList());

            int[] C = { 3, 1, 2, 4 };
            int[] testArray2 = SortArrayByParityViaList.SortArrayByParityList(C);
            printIntList(testArray2.ToList());

            string D = "RLRRLLRLRL";
            Console.WriteLine(SplitBalancedString.BalancedStringSplit(D));

            int[] E = { -4, -1, 0, 3, 10 };
            int[] testArray3 = SquaresOfSortedArray.SortedSquares(E);
            printIntList(testArray3.ToList());

            string str = "Hello";
            Console.WriteLine(ToLowerCase.ConvertToLowerCase(str));

            string[] words = { "gin", "zen", "gig", "msg" };
            HashSet<string> testSet = UniqueMorseCodeWords.ConvertAllWordsToMorseCode(words);


            int[] arr = { 1, 2, 2, 1, 1, 3 };
            Dictionary<int, int> testMap = UniqueNumberOccurrences.UniqueOccurrences(arr);
            printDictionary(testMap);*/
        }

        public static void printHashSet(HashSet<string> testSet)
        {
            foreach (var i in testSet)
            {
                Console.WriteLine(i);
            }
        }

        public static void printDictionary(Dictionary<int, int> testMap)
        {
            foreach (KeyValuePair<int, int> i in testMap)
            {
                Console.WriteLine(i);
            }
        }

        public static void printDictionaryChar(Dictionary<char, int> testMap)
        {
            foreach (KeyValuePair<char, int> i in testMap)
            {
                Console.WriteLine(i);
            }
        }

        public static void printList(List<string> testList)
        {
            foreach (var i in testList)
            {
                Console.WriteLine(i);
            }
        }

        public static void printIntList(List<int> testList)
        {
            foreach (var i in testList)
            {
                Console.WriteLine(i);
            }
        }
    }
}


