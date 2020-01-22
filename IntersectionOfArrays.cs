using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Problems
{
    class IntersectionOfArrays
    {
        public static int[] Intersection(int[] nums1, int[] nums2)
        {
            //Input: nums1 = [1,2,2,1], nums2 = [2,2]
            //Output: [2]

            HashSet<int> arr1 = new HashSet<int>(nums1);
            HashSet<int> result = new HashSet<int>();

            for (int i = 0; i < nums2.Length; i++)
            {
                if (arr1.Contains(nums2[i]))
                {
                    result.Add(nums2[i]);
                }
            }

            return result.ToArray();
        }
    }
}
