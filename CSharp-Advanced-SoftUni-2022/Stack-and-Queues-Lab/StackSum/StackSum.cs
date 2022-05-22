using System;
using System.Collections.Generic;
using System.Linq;

namespace StackSum
{
    internal class StackSum
    {
        static void Main(string[] args)
        {
            Stack<int> sum = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

            string[] command = Console.ReadLine().ToLower().Split().ToArray();

            while (command[0] != "end")
            {
                if (command[0] == "add")
                {
                    sum.Push(int.Parse(command[1]));
                    sum.Push(int.Parse(command[2]));
                }
                else if (command[0] == "remove")
                {
                    if (sum.Count >= int.Parse(command[1]))
                    {
                        for (int i = 0; i < int.Parse(command[1]); i++)
                            sum.Pop();
                    }

                }

                command = Console.ReadLine().ToLower().Split().ToArray();
            }

            Console.WriteLine($"Sum: {sum.Sum()}");
        }
    }
}
