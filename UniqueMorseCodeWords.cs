using System;
using System.Collections.Generic;

namespace Problems
{
    public class UniqueMorseCodeWords
    {
        public static string ConvertOneWordToMorseCode(string oneWord)
        {
            string[] morseCode = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
            char[] wordLetters = oneWord.ToCharArray();
            string[] morseLetters = new string[wordLetters.Length];
            for (int i = 0; i < wordLetters.Length; i++)
            {
                int morseIndex = wordLetters[i] - 97;
                string morseLetter = morseCode[morseIndex];

                morseLetters[i] = morseLetter;
            }
            string morseWord = String.Join("", morseLetters);

            return morseWord;
        }

        public static HashSet<string> ConvertAllWordsToMorseCode(string[] words)
        {
            HashSet<string> morseWords = new HashSet<string>();
            for (int j = 0; j < words.Length; j++)
            {
                var oneWord = words[j];

                morseWords.Add(ConvertOneWordToMorseCode(oneWord));
            }
            return morseWords;
        }

        public static int CompareMorseWords(HashSet<string> morseWords)
        {
            return morseWords.Count;
        }
    }
}