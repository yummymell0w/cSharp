using System.Collections.Generic;
using System.Linq;
using System.Text;

public class FindCommonCharacters
{
    //Input: ["bella","label","roller"]
    //Output: ["e","l","l"]

    //convert string to dict
    public static Dictionary<char, int> toDictionary(string word)
    {
        Dictionary<char, int> wordDict = new Dictionary<char, int>();
        char[] charArr = word.ToCharArray();
        for (int i = 0; i < charArr.Length; i++)
        {
            int count = 1;
            if (wordDict.ContainsKey(charArr[i]))
            {
                char myKey = charArr[i];
                wordDict[myKey] = count++;
            }
            else
            {
                wordDict.Add(charArr[i], count);
            }
        }
        return wordDict;
    }

    public static List<string> CommonChars(string[] A)
    {
        //add dictionary to array of dict
        Dictionary<char, int>[] jagged = new Dictionary<char, int>[A.Length];
        for (int i = 0; i < A.Length; i++)
        {
            jagged[i] = toDictionary(A[i]);
        }

        //declare empty dictionary for repeating letters
        Dictionary<char, int> repeatedLetters = new Dictionary<char, int>();

        //compare dictionaries and add repeating dict to the new dict
        for (int i = 0; i < jagged.Length - 1; i++)
        {
            for (int j = i + 1; j < jagged.Length; j++)
            {
                repeatedLetters = jagged[j].Where(entry => jagged[i][entry.Key] != entry.Value)
                 .ToDictionary(entry => entry.Key, entry => entry.Value);
            }
        }

        //conver final dict to a list or string, if int value> 1 then add char the # of times = int value
        List<string> result = new List<string>();
        foreach (var x in repeatedLetters)
        {
            for (int counter = x.Value; counter > 0; counter--)
            {
                result.Add(x.Key.ToString());
            }
        }

        return result;
    }
}

