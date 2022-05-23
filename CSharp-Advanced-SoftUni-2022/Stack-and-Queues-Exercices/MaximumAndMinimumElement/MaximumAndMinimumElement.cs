using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumAndMinimumElement
{
    internal class MaximumAndMinimumElement
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int[] query = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (query.Length == 2 && query[0] == 1)
                    stack.Push(query[1]);

                else if (query.Length < 2 && query[0] == 2)
                    stack.Pop();

                else if (query.Length < 2 && query[0] == 3 && stack.Count > 0)
                    Console.WriteLine(stack.Max());

                else if (query.Length < 2 && query[0] == 4 && stack.Count > 0)
                    Console.WriteLine(stack.Min());
            }

            Console.WriteLine(String.Join(", ",stack));
        }
    }
}
