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
            Dictionary<int, int> dick = new Dictionary<int, int>();
            for (int i = 0; i < nums1.Length; i++)
            {
                if (dick.TryGetValue(nums1[i], out int count))
                {
                    dick[nums1[i]] = count + 1;
                }
                else
                {
                    dick[nums1[i]] = 1;
                }
            }

            List<int> result = new List<int>(nums1.Length);
            for (int j = 0; j < nums2.Length; j++)
            {
                if (dick.TryGetValue(nums2[j], out int count))
                {
                    if (count > 0)
                    {
                        result.Add(nums2[j]);
                        dick[nums2[j]] = count - 1;
                    }
                }
            }

            return result.ToArray();
        }
    }
}
