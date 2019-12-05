using System;
using System.Collections.Generic;

namespace Problems
{
    public class UniqueMorseCodeWords
    {
        public string ConvertOneWordToMorseCode(string oneWord)
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
            string morseWord = String.Join("", morseLetters);

            return morseWord;
        }

        public HashSet<string> ConvertAllWordsToMorseCode(string[] words)
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

        public int CompareMorseWords(HashSet<string> morseWords)
        {
            return morseWords.Count;

        }
    }
}