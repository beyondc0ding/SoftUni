using System;
using System.Collections.Generic;
using System.Linq;

namespace BalancedParenthesis
{
    internal class BalancedParenthesis
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                char expectedParentheses = '(';
                bool isBalanced = false;

                if (input[i] == ')')
                {
                    isBalanced = true;
                }
                else if (input[i] == ']')
                {
                    expectedParentheses = '[';
                    isBalanced = true;
                }
                else if (input[i] == '}')
                {
                    expectedParentheses = '{';
                    isBalanced = true;
                }
                else
                {
                    stack.Push(input[i]);
                }

                if (isBalanced)
                {
                    if (stack.Count == 0 || stack.Pop() != expectedParentheses)
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
            }

            Console.WriteLine("YES");
        }
    }
}
