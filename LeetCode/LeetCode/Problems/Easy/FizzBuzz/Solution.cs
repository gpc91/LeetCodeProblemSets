using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Easy.FizzBuzz
{
    class Solution : IExecutable
    {        
        public IList<string> FizzBuzz(int n)
        {
            List<string> result = new List<string>();
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= n; i++)
            {
                if ( i % 3 == 0)
                {
                    sb.Append("Fizz");
                }

                if ( i % 5 == 0)
                {
                    sb.Append("Buzz");
                }

                if (!(i % 3 == 0) && !(i % 5 == 0))
                {
                    sb.Append(i.ToString());
                }

                result.Add(sb.ToString());
                sb.Clear();
            }
            return result;
        }

        public void Execute()
        {
            int n = LeetCode.Helper.ReadInteger(1, 10000);            
            List<string> fb = (List<string>)FizzBuzz(n);

            // Print out the List object formatted like an array of strings.
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            foreach (string s in fb)
            {
                sb.Append(String.Format("\"{0}\", ", s));
            }
            sb.Remove(sb.Length - 2, 2);
            sb.Append("]");
            Console.WriteLine(sb.ToString());
            sb.Clear();
        }

    }
}
