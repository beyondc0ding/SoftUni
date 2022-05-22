﻿using System;
using System.Collections.Generic;

namespace TrafficJam
{
    internal class TrafficJam
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            Queue<string> queue = new Queue<string>();

            int counter = 0;

            while (command != "end")
            {
                if (command == "green")
                {

                    for (int i = 0; i < n; i++)
                    {
                        if (queue.Count == 0)
                            break;

                        Console.WriteLine($"{queue.Dequeue()} passed!");
                        counter++;
                    }
                }
                else
                {
                    queue.Enqueue(command);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}
