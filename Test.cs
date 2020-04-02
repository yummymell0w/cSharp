using System;
using System.Collections.Generic;
using System.Text;

namespace Problems
{
    public class Test
    {
        public static void Swap(ref string a, ref string b)
        {
            var temp = a;
            a = b;
            b = temp;
        }
    }
}
