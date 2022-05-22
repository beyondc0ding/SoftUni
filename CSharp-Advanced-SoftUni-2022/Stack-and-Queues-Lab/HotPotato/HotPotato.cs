using System;
using System.Collections.Generic;

namespace HotPotato
{
    internal class HotPotato
    {
        static void Main(string[] args)
        {

            Queue<string> players = new Queue<string>(Console.ReadLine().Split());

            int n = int.Parse(Console.ReadLine());

            while (players.Count > 1)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    players.Enqueue(players.Dequeue());
                }

                Console.WriteLine($"Removed {players.Dequeue()}");
            }

            Console.WriteLine($"Last is {players.Peek()}");
        }
    }
}
