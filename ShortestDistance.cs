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

            for (int i = 0; i < letters.Length; i++)
            {
                for (int j = 0; i < letters.Length; j++)
                {
                    if (letters[i] != C)
                    {

                        distance[i] = Array.IndexOf(letters, C) - letters[i];
                    }
                    else
                    {
                        distance[i] = 0;
                    }

                   
                }
            }



            return distance;

        }

        public static int CalculateDistance(char[] letters, char C, int i])
        {

        }

    }
}
