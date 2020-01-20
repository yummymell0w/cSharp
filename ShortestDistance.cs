using System;
using System.Collections.Generic;
using System.Text;

namespace Problems
{
    class ShortestDistance
    {
        public static int[] ShortestToChar(string S, char C)
        {
            //Input: S = "loveleetcode", C = 'e'
            // Output: [3, 2, 1, 0, 1, 0, 0, 1, 2, 2, 1, 0]
            char[] letters = S.ToCharArray();
            int[] distance = new int[letters.Length];

            for (int index = 0; index < letters.Length; index++)
            {
                distance[index] = CalculateDistance(letters, C, index);
            }

            return distance;
        }

        public static int CalculateDistance(char[] letters, char C, int index)
        {
            int i = 0;
            while(!(index + i < letters.Length && letters[index + i] == C || index - i >= 0 && letters[index - i] == C))
            {
                i++;
            }

            return i;
        }

    }

}

