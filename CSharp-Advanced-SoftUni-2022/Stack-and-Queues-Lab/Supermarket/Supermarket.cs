using System;
using System.Collections.Generic;

namespace Supermarket
{
    internal class Supermarket
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Queue<string> customers = new Queue<string>();

            while (input != "End")
            {
                if (input == "Paid")
                {
                    foreach (var customer in customers)
                    {
                        Console.WriteLine(customer);
                    }
                    customers.Clear();
                }
                else
                {
                    customers.Enqueue(input);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"{customers.Count} people remaining.");
        }
    }
}
