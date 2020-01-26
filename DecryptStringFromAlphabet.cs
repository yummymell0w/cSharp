using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Problems
{
    class DecryptStringFromAlphabet
    {
        public static string FreqAlphabets(string s)
        {
            Dictionary<string, char> abc = new Dictionary<string, char>();
            for (int i = 1; i < 10; i++)
            {
                abc.Add(i.ToString(), (char)('a' + i - 1));
            }

            for (int j = 10; j < 27; j++)
            {
                abc.Add(j.ToString() + "#", (char)('a' + j - 1));
            }

            char[] input = s.ToCharArray();
            StringBuilder output = new StringBuilder(input.Length);

            for (int x = input.Length - 1; x >= 0; x--)
            {
                if (input[x] == '#')
                {
                    string key = input[x - 2].ToString() + input[x - 1].ToString() + "#";
                    output.Append(abc[key]);
                    x = x - 2;
                }
                else
                {
                    output.Append(abc[input[x].ToString()]);
                }
            }
           
            char[] arr= output.ToString().ToCharArray();
            Array.Reverse(arr);
           
            return new string(arr);
        }
    }
}

