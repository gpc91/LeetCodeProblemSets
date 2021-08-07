/*
 * Problem Set: https://leetcode.com/problems/add-two-numbers
 * Result:      https://leetcode.com/submissions/detail/534608869/
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Medium.AddTwoNumbers
{

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        // Custom ListNode Builder
        public static ListNode Build(int value, params int[] values)
        {
            ListNode root = new ListNode(value);
            ListNode node = root;
            foreach (int val in values)
            {
                node.next = new ListNode(val);
                node = node.next;
            }
            return root;
        }

        // Custom ListNode Printer
        public void Print()
        {
            ListNode ptr = this;
            while (ptr != null)
            {
                Console.Write(ptr.val);
                ptr = ptr.next;
            }
            Console.WriteLine();
        }

    }

    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode root = new ListNode();
            ListNode current = root;

            while (true)
            {
                current.val +=
                    (l1 != null ? l1.val : 0)
                +
                    (l2 != null ? l2.val : 0);

                if (l1 != null) l1 = l1.next;
                if (l2 != null) l2 = l2.next;

                // if there is no carry left over and we have reached the end of both lists then break out of while loop.
                if (l1 == null && l2 == null && (current.val / 10) == 0)
                {
                    break;
                }
                else
                {
                    // create a new node with the remainder of sum over 10.
                    current.next = new ListNode(current.val / 10);
                    // set the value to the quotient of the sum of 10 to keep it correctly clamped after the carry
                    current.val %= 10;
                    current = current.next;
                }
            }
            return root;
        }
       
    }
}
