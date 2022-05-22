using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintEvenNumbers
{
    internal class PrintEvenNumbers
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>();

            foreach (int i in input)
            {
                if (i % 2 == 0)
                {
                    queue.Enqueue(i);
                }
            }

            Console.WriteLine(String.Join(", ", queue));
        }
    }
}
