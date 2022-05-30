using System;
using System.Collections.Generic;
using System.Linq;

namespace PeriodicTable
{
    class PeriodicTable
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedSet<string> periodicTable = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                AddElements(input, periodicTable);
            }

            PrintElements(periodicTable);
        }

        static void AddElements(string[] input, SortedSet<string> periodicTable)
        {
            foreach (var element in input)
            {
                periodicTable.Add(element);
            }
        }

        static void PrintElements(SortedSet<string> periodicTable)
        {
            Console.WriteLine(String.Join(" ", periodicTable));
        }
    }
}