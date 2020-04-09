using System;
using System.Collections.Generic;
using System.Text;

namespace Problems.Leetcode_30_days
{
    public class Day8MiddleOfLinkedList
    {
        public static ListNode MiddleNode(ListNode head)
        {
            //find middle node or second middle node
            //input [1,2,3,4,5]

            ListNode temp = head;

            if (temp.next == null)
            {
                return temp;
            }

            int counter = 1;
            while (temp.next != null)
            {
                temp = temp.next;
                counter++;
            }

            int middle;

            if (counter % 2 != 0)
            {
                middle = counter / 2;
            }
            else
            {
                middle = counter + 1;
                middle = middle / 2;
            }

            int i = 1;
            while(i <= middle)
            {
                head = head.next;
                i++;
            }

            return head;
        }
    }
}
