using System;
using LeetCode.Problems.Medium.AddTwoNumbers;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {

            ListNode l1 = ListNode.Build(2, 3, 4);
            l1.Print();

            ListNode l2 = ListNode.Build(5, 6, 8);
            l2.Print();

            Solution solution = new Solution();
            ListNode result = solution.AddTwoNumbers(l1, l2);
            result.Print();
        }
    }
}
