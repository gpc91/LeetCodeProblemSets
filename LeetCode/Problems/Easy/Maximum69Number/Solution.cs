/*
 * Problem:     https://leetcode.com/problems/maximum-69-number/
 * Solution:    https://leetcode.com/submissions/detail/534619615/
 * 
 * C Solution:  https://leetcode.com/submissions/detail/487905935/      
 * CPP Solution:https://leetcode.com/submissions/detail/487853559/    
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Easy.Maximum69Number
{
    class Solution : IExecutable
    {
        public void Execute()
        {
            int n = 6696;
            Console.WriteLine("Maximum of {0} is: {1}.", n, Maximum69Number(n));
        }

        public int Maximum69Number(int num)
        {
            char[] n = num.ToString().ToCharArray();
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] == '6')
                {
                    n[i] = '9';
                    break;
                }
            }
            return int.Parse(n);
        }
    }
}
