using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
{
    internal class BasicStackOperations
    {
        static void Main(string[] args)
        {
            int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int n = data[0];
            int s = data[1];
            int x = data[2];

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                stack.Push(numbers[i]);
            }

            for (int i = 0; i < s; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                if(stack.Count < 1)
                    Console.WriteLine(0);
                else
                Console.WriteLine(stack.Min());
            }
        }
    }
}
