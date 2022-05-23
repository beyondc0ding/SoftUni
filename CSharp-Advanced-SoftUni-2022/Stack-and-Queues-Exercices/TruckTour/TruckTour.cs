using System;
using System.Collections.Generic;
using System.Linq;

namespace TruckTour
{
    internal class TruckTour
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Queue<string> queue = new Queue<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                input += $" {i}";
                queue.Enqueue(input);
            }

            int totalFuel = 0;

            for (int i = 0; i < n; i++)
            {
                string getData = queue.Dequeue();
                int[] petrolPump = getData.Split().Select(int.Parse).ToArray();

                int fuel = petrolPump[0];
                int distance = petrolPump[1];
                totalFuel += fuel;

                if (totalFuel >= distance)
                {
                    totalFuel -= distance;
                }
                else
                {
                    totalFuel = 0;
                    i = -1;
                }

                queue.Enqueue(getData);
            }

            int[] smallestIndex = queue.Dequeue().Split().Select(int.Parse).ToArray();

            Console.WriteLine(smallestIndex[2]);
        }
    }
}
