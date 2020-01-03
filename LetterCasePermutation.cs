using System.Collections.Generic;


public class LetterCasePermutation
{
    public static List<string> LetterPermutation(string S)
    {
        List<string> result = new List<string>();
        int index = 0;
        char[] charArray = new char[S.Length];
        char[] source = S.ToCharArray();
        permutation(source, charArray, index, result);
        return result;
    }

    public static void permutation(char[] source, char[] charArray, int index, List<string> result)
    {
        //base condition
        if (index >= source.Length)
        {
            result.Add(new string(charArray));
            return;
        }

        // function
        charArray[index] = source[index];
        permutation(source, charArray, index + 1, result);

        if (!(source[index] >= 48 && source[index] <= 57))
        {
            charArray[index] = change(source[index]);
            permutation(source, charArray, index + 1, result);
        }
        
    }

    static char change(char c)
    {
        if (c >= 65 && c <= 90)
        {
            return (char)(c + 32);
        }
        else
        {
            return (char)(c - 32);
        }
    }
}