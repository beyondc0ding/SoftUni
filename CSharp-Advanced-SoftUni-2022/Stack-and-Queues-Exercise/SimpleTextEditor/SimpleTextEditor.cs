using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTextEditor
{
    internal class SimpleTextEditor
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            StringBuilder textBuilder = new StringBuilder();

            Stack<string> textLastState = new Stack<string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "1")
                {
                    textLastState.Push(textBuilder.ToString());

                    string textToAppend = command[1];

                    textBuilder.Append(textToAppend);
                }
                else if (command[0] == "2")
                {
                    textLastState.Push(textBuilder.ToString());

                    int countOfElements = int.Parse(command[1]);

                    textBuilder.Remove(textBuilder.Length - countOfElements, countOfElements);
                }
                else if (command[0] == "3")
                {
                    int index = int.Parse(command[1]);

                    Console.WriteLine(textBuilder[index - 1]);
                }
                else if (command[0] == "4")
                {
                    textBuilder.Clear();
                    textBuilder.Append(textLastState.Pop());
                }
            }
        }
    }
}
