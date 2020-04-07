using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;

namespace Problems.Leetcode_30_days
{
    public class Day6AnagramGroups
    {
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            IList<IList<string>> groups = new List<IList<string>>();


            foreach (var word in strs)
            {
                if (word != null)
                {
                    IList<string> words = new List<string>();

                    for (int i = 0; i < strs.Length; i++)
                    {
                        if (strs[i] != null)
                        {
                            string firstWord = WordToDictionary(word);
                            string secondWord = WordToDictionary(strs[i]);
                            if (firstWord == secondWord)
                            {
                                words.Add(strs[i]);
                                strs[i] = null;
                            }
                        }
                    }

                    groups.Add(words);
                }
            }

            return groups;
        }


        public static string WordToDictionary(string str)
        {
            char[] arr = str.ToCharArray();
            Array.Sort(arr);
            string word = new string(arr);
            return word;
        }
    }
}
