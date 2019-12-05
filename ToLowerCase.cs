using System;

namespace Problems
{
    public class ToLowerCase
    {
        /*
        //v1
    public class Solution {
        public string ConvertToLowerCase(string str) {
            string lowerCase = str.ToLower();
            return lowerCase;
        }
    }
    */

        // v2
        public string ConvertToLowerCase(string str)
        {
            char[] upperChars = str.ToCharArray();
            char[] lowerChars = new char[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                if (upperChars[i] >= 65 && upperChars[i] <= 90)
                {
                    char lowerLetter = (char)(upperChars[i] + 32);
                    lowerChars[i] = lowerLetter;
                }
                else
                {
                    lowerChars[i] = upperChars[i];
                }
            }
            string lowerCase = new String(lowerChars);
            return lowerCase;

        }
    }
}