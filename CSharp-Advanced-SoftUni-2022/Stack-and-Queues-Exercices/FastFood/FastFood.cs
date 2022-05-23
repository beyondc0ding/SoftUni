using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    internal class FastFood
    {
        static void Main(string[] args)
        {
            int quanity = int.Parse(Console.ReadLine());

            int[] ordersInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> orders = new Queue<int>(ordersInput);

            Console.WriteLine(orders.Max());

            while (orders.Count > 0)
            {
                if (quanity >= orders.Peek())
                    quanity -= orders.Dequeue();

                else
                {
                    Console.WriteLine($"Orders left: {String.Join(' ',orders)}");
                        break;
                }

            }
            if(orders.Count == 0)
            Console.WriteLine("Orders complete");
        }
    }
}
