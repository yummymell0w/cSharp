﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;



class Program
{
    /*
    public int CompareOneJewelToStones(char jewel, string S)
    {
        char[] stones = S.ToCharArray();
        int myJewels = 0;
        int i = 0;
        while (i < stones.Length)
        {
            if (jewel == stones[i])
                myJewels++;
            i++;

        }
        return myJewels;
    }
    public int NumJewelsInStones(string J, string S)
    {
        char[] jewels = J.ToCharArray();
        int myJewels = 0;
        int i = 0;
        while (i < jewels.Length)
        {
            int result = CompareOneJewelToStones(jewels[i], S);
            myJewels = myJewels + result;
            i++;

        }
        return myJewels;

    }


    public static int NumJewelsInStones(string J, string S)
    {
        char[] stones = S.ToCharArray();
        char[] jewels = J.ToCharArray();
        int myJewels = 0;
        int i = 0;
        while (i < S.Length)
        {
            foreach (char jewel in jewels)
            {
                if (jewel == stones[i])
                    myJewels++;

            }
            i++;
        }
        return myJewels;
    }

     Single row keyboard problem:

    public static int CalculateTime(string keyboard, string word)
    {
        char[] alphabet = keyboard.ToCharArray();
        char[] input = word.ToCharArray();
        int i = 0;
        int index = 0;

        while (i < alphabet.Length)
        {foreach (char letter in input){

            if (input[i] == alphabet[i])
            {
                index = Array.IndexOf(alphabet, alphabet[i]);

            }
            }
            i++;

        }
        return index;
    }
    */

    /*public static int[] SortArrayByParity(int[] A)
    {
        int[] B = new int[A.Length];
        int[] C = new int[A.Length];
        int j = 0;
        int k = 0;

        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] % 2 == 0)
            {
                // create array with even numbers
                B[j] = A[i];
                j++;
            }else{
                // create array with odd number
                C[k] = A[i];
                k++;
            }
        }
        // concatinate 2 arrays

        int[] D = new int[A.Length];
        for (int i = 0; i < j; i++)
        {
            D[i] = B[i];
        }

        for (int i = 0; i < k; i++)
        {
            D[j+i] = C[i];
        }


        // return new array
        return D;
    }

    // Sort array by parity via List
    public static int[] SortArrayByParity(int[] A)
    {
        List<int> B = new List<int>();
        List<int> C = new List<int>();
        int j = 0;
        int k = 0;

        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] % 2 == 0)
            {
                // create list with even numbers
               
                B.Add(A[i]);
                j++;
            }
            else
            {
                // create list with odd number
            
                C.Add(A[i]);
                k++;
            }
        }


        // concatinate 2 lists
        List<int> D = new List<int>();
        D.AddRange(B);
        D.AddRange(C);
        int[] E = D.ToArray();

        // return new array
        return E;
    }

    //Unique Morse Code Words

    public static string ConvertOneWordToMorseCode(string oneWord)
    {
        string[] morseCode = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
        //convert a word from string to array of chars
        char[] wordLetters = oneWord.ToCharArray();
        string[] morseLetters = new string[wordLetters.Length];
        //loop to convert letters to Morse code
        for (int i = 0; i < wordLetters.Length; i++)
        {
            int morseIndex = wordLetters[i] - 97;
            string morseLetter = morseCode[morseIndex];

            morseLetters[i] = morseLetter;
        }
        string morseWord = String.Join("",morseLetters);
        
        return morseWord;
    }

    public static HashSet<string> ConvertAllWordsToMorseCode(string[] words)
    {
        //loop to  convert each word in morse code word
        HashSet<string> morseWords = new HashSet<string>();
        for (int j = 0; j < words.Length; j++)
        {
            //take one word from array of words
            var oneWord = words[j];

            morseWords.Add(ConvertOneWordToMorseCode(oneWord));
        }
        return morseWords;
    }

    public static int CompareMorseWords(HashSet<string> morseWords)
    {
        return morseWords.Count;
       
    }

    //1108. Defanging an IP Address
    public static string DefangIPaddr(string ipAddress)
    {
        //declare new string builder
        StringBuilder sb = new StringBuilder();
        char[] arrayAddress = new char[ipAddress.Length];
        arrayAddress = ipAddress.ToCharArray();
        //go through each element of array of chars and if char matches . then add [.] to string builder object
        for (int i = 0; i < ipAddress.Length; i++)
        {
            if (arrayAddress[i] == '.')
            {
                sb.Append("[.]");
                
            }
            else
            {
                sb.Append(arrayAddress[i]);
            }

        }
        //convert string builder object to string
        string defangIP = sb.ToString();
        //return result
        return defangIP;

    }

    // To lower case
    public static string ToLowerCase(string str) {  
        char[] upperChars = str.ToCharArray();
        char[] lowerChars = new char[str.Length];
        for (int i = 0; i < str.Length; i++)
        {
            if(upperChars[i] >= 65 && upperChars[i] <=90)
            {
            char lowerLetter = (char)(upperChars[i] + 32);
            lowerChars[i] = lowerLetter;
            } else 
            {
            lowerChars[i] = upperChars[i];
            } 
        }
        string lowerCase = new String(lowerChars);
        return lowerCase;
        
    }*/

    // Unique Number of Occurrences
    public static Dictionary<int, int> UniqueOccurrences(int[] arr) {
      //create a dictionary from given array of int
      Dictionary<int, int> map = new Dictionary<int, int>();
      for (int i=0; i<arr.Length; i++){
          if (!map.ContainsKey(arr[i]))
          {
              map.Add(arr[i], 1);
          } else
          {
              map[arr[i]] += 1;
          }
        
      }
     return map; 

    }

    public static bool CountOccurrences(Dictionary<int,int> map)
    {
        int[] newMap = map.Values.ToArray();
        //int myJewels = 0;
        
        for (int i = 0; i < newMap.Length-1; i++)
        {
            for (int j=i+1; j < newMap.Length; j++)
            {
                if (newMap[i] == newMap[j])
                    return false;

            }
            
        }
        return true;
    }

    static public void Main(string[] args)
    {
        int[] arr = new int[] {1,2,2,1,1,3};
        //Dictionary<int, int> print = UniqueOccurrences(arr);
        //foreach(KeyValuePair<int, int> item in print)
        //{
        Console.Write(CountOccurrences(UniqueOccurrences(arr)));
        //}
        



    }

}




