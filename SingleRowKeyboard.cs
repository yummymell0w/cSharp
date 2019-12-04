using System;

namespace Problems
{
    public class SingleRowKeyboard
    {
        public static int CalculateTime(string keyboard, string word)
        {
            char[] alphabet = keyboard.ToCharArray();
            char[] input = word.ToCharArray();
            int i = 0;
            int index = 0;

            while (i < alphabet.Length)
            {
                foreach (char letter in input)
                {

                    if (input[i] == alphabet[i])
                    {
                        index = Array.IndexOf(alphabet, alphabet[i]);

                    }
                }
                i++;

            }
            return index;
        }
    }
}