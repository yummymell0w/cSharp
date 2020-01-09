using System.Collections.Generic;
using System.Linq;
using System.Text;

public class FindCommonCharacters
{
    public static Dictionary<char, int> toDictionary(string word)
    {
        Dictionary<char, int> wordDict = new Dictionary<char, int>();
        char[] charArr = word.ToCharArray();
        for (int i = 0; i < charArr.Length; i++)
        {
            if (wordDict.TryGetValue(charArr[i], out int count))
            {
                wordDict[charArr[i]] = count + 1;
            }
            else
            {
                wordDict.Add(charArr[i], 1);
            }
        }
        return wordDict;
    }

    public static List<string> CommonChars(string[] A)
    {
        //add dictionary to array of dict
        Dictionary<char, int>[] allDict = new Dictionary<char, int>[A.Length];
        for (int i = 0; i < A.Length; i++)
        {
            allDict[i] = toDictionary(A[i]);
        }

        //declare empty dictionary for repeating letters
        List<string> repeatingLetters = new List<string>();

        //compare dictionaries and add repeating dict to the new dict
        foreach (var letter in allDict[0])
        {
            int min = letter.Value;
            for (int i = 1; i < allDict.Length; i++)
            {
                if (allDict[i].TryGetValue(letter.Key, out int value))
                {
                    if (value < min)
                    {
                        min = value;
                    }
                }
                else
                {
                    min = 0;
                    break;
                }
            }

            for (; min > 0; min--)
            {
                repeatingLetters.Add(letter.Key.ToString());
            }
        }
        return repeatingLetters;
    }
}

