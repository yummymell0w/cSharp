using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Problems
{
    class IntersectionOfArraysII
    {
        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            //Input: nums1 = [1,2,2,1], nums2 = [2,2]
            //Output: [2,2]
            Dictionary<int, int> dict1 = new Dictionary<int, int>();

            for (int i = 0; i < nums1.Length; i++)
            {
                if (dict1.TryGetValue(nums1[i], out int count))
                {
                    dict1[nums1[i]] = count + 1;
                }
                else
                {
                    dict1.Add(nums1[i], 1);

                }
            }

            Dictionary<int, int> dict2 = new Dictionary<int, int>();

            for (int j = 0; j < nums2.Length; j++)
            {
                if (dict2.TryGetValue(nums2[j], out int count))
                {
                    dict2[nums2[j]] = count + 1;
                }
                else
                {
                    dict2.Add(nums2[j], 1);

                }
            }

            List<int> result = new List<int>();

            foreach (var number in dict1)
            {
                int min = number.Value;
                dict2.TryGetValue(number.Key, out int count);
                if (min > count)
                {
                    min = count;
                }

                for (; min > 0; min--)
                {
                    result.Add(number.Key);
                }
            }

            return result.ToArray();
        }
    }
}
