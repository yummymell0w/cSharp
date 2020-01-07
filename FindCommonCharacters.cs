using System.Collections.Generic;

public class FindCommonCharacters
{
    public static IList<string> CommonChars(string[] A)
    {
        //Input: ["bella","label","roller"]
        //Output: ["e","l","l"]

        Dictionary<int, char> listOfLetters = new Dictionary<int, char>();
        char[][] wordsArray = new char[][] { };

        {
            for (int i = 0; i < A.Length; i++)
            {
                char[] chars = A[i].ToCharArray();
                wordsArray[i] = new char[] { chars };
            }

        };

        for (int i = 0; i < A.Length; i++)
        {
            char[] chars = A[i].ToCharArray();
            for (int j = 0; j < chars.Length; j++)
            {
                
            }
        }



    }
}