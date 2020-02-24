using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Compression;
using System.Text;

namespace Problems.ConvertBinaryToInteger
{
    class ConvertBinaryToInt
    {
        public int GetDecimalValue(ListNode head)
        {
            //Input: head = [1, 0, 1]
            //formula
            // 101= (1*2^2)+(0*2^1)+(1*2^0)
            
                int result = 0;
                while (head != null)
                {
                    result = result * 2 + head.val;
                    head = head.next;
                }

                return result;
        }
    }
}
