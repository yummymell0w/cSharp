using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems
{
    public class UniqueNumberOccurrences
    {
        public Dictionary<int, int> UniqueOccurrences(int[] arr)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (!map.ContainsKey(arr[i]))
                {
                    map.Add(arr[i], 1);
                }
                else
                {
                    map[arr[i]] += 1;
                }
            }
            return map;

        }

        public bool CountOccurrences(Dictionary<int, int> map)
        {
            int[] newMap = map.Values.ToArray();
            for (int i = 0; i < newMap.Length - 1; i++)
            {
                for (int j = i + 1; j < newMap.Length; j++)
                {
                    if (newMap[i] == newMap[j])
                        return false;
                }
            }
            return true;
        }
    }
}