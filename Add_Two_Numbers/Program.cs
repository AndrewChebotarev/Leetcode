/*
2. Add Two Numbers

You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.

You may assume the two numbers do not contain any leading zero, except the number 0 itself.

Example 1:

Input: l1 = [2,4,3], l2 = [5,6,4]
Output: [7,0,8]
Explanation: 342 + 465 = 807.

Example 2:

Input: l1 = [0], l2 = [0]
Output: [0]

Example 3:

Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
Output: [8,9,9,9,0,0,0,1]

Constraints:

The number of nodes in each linked list is in the range [1, 100].
0 <= Node.val <= 9
It is guaranteed that the list represents a number that does not have leading zeros.
*/

using System;

namespace Add_Two_Numbers
{
    public class Program
    {
        private static int[] l1Array = { 2, 4, 3 };
        private static int[] l2Array = { 5, 6, 4 };

        private static int[] l3Array = { 0 };
        private static int[] l4Array = { 0 };

        private static int[] l5Array = { 9, 9, 9, 9, 9, 9, 9 };
        private static int[] l6Array = { 9, 9, 9, 9 };

        private static ListNode l1 = new(l1Array[0]);
        private static ListNode l2 = new(l2Array[0]);
        private static ListNode l3 = new(l3Array[0]);
        private static ListNode l4 = new(l4Array[0]);
        private static ListNode l5 = new(l5Array[0]);
        private static ListNode l6 = new(l6Array[0]);

        public static void Main(string[] args)
        {
            FillListNode(ref l1, l1Array);
            FillListNode(ref l2, l2Array);

            Add_Two_Numbers add_Two_Numbers1 = new(l1, l2);
            Console.WriteLine();

            FillListNode(ref l3, l3Array);
            FillListNode(ref l4, l4Array);

            Add_Two_Numbers add_Two_Numbers2 = new(l3, l4);
            Console.WriteLine();

            FillListNode(ref l5, l5Array);
            FillListNode(ref l6, l6Array);

            Add_Two_Numbers add_Two_Numbers3 = new(l5, l6);
        }

        private static void FillListNode(ref ListNode l, int[] lArray)
        {
            ListNode temp = l;
            for (int index = 1; index < lArray.Length; index++)
            {
                temp.next = new ListNode(lArray[index]);
                temp = temp.next;
            }
        }
    }
}
