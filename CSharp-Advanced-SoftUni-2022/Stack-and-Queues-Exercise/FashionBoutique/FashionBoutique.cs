using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique
{
    internal class FashionBoutique
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> clothesInput = new Stack<int>(input);

            int capacity = int.Parse(Console.ReadLine());

            int racks = 0;

            int sum = 0;

            while(clothesInput.Count > 0) 
            {
                if (sum + clothesInput.Peek() < capacity)
                    sum += clothesInput.Pop();

                else if (sum + clothesInput.Peek() == capacity)
                {
                    racks++;
                    clothesInput.Pop();
                    sum = 0;
                }

                else
                {
                    sum = clothesInput.Pop();
                    racks++;
                }
                    
            }

            if (sum > 0)
                racks++;

            Console.WriteLine(racks);
        }
    }
}
