using System;
using System.Collections.Generic;
using System.Linq;

namespace SongsQueue
{
    internal class SongsQueue
    {
        static void Main(string[] args)
        {
           Queue<string> queue = new Queue<string>(Console.ReadLine().Split(", ").ToArray());

            while (queue.Count > 0)
            {
                string command = Console.ReadLine();

                if (command == "Play")
                {
                    queue.Dequeue();
                }

                else if (command == "Show")
                {
                    Console.WriteLine(String.Join(", ", queue));
                }

                else if (command.StartsWith("Add"))
                {
                    string[] songCommand = command.Split(new[] { "Add " },StringSplitOptions.None).ToArray();
                    
                    string songToAdd = String.Join("", songCommand);

                    if(!queue.Contains(songToAdd))
                        queue.Enqueue(songToAdd);

                    else
                        Console.WriteLine($"{songToAdd} is already contained!");
                }

            }

            Console.WriteLine("No more songs!");
        }
    }
}
