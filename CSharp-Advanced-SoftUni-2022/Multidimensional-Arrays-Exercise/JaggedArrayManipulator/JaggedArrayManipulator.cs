using System;
using System.Linq;

namespace JaggedArrayManipulator
{
    internal class JaggedArrayManipulator
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            double[][] jugg = new double[rows][];

            for (int i = 0; i < rows; i++)
            {
                jugg[i] = Console.ReadLine().Split().Select(double.Parse).ToArray();
            }

            for (int i = 0; i < rows - 1; i++)
            {
                if (jugg[i].Count() == jugg[i + 1].Count())
                {
                    jugg[i] = jugg[i].Select(x => x * 2).ToArray();
                    jugg[i + 1] = jugg[i + 1].Select(x => x * 2).ToArray();
                }
                else
                {
                    jugg[i] = jugg[i].Select(x => x / 2).ToArray();
                    jugg[i + 1] = jugg[i + 1].Select(x => x / 2).ToArray();
                }
            }

            string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "End")
            {
                string operand = command[0];
                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                double value = double.Parse(command[3]);

                if (!IsCoordinatesValid(jugg, row, col))
                {
                    command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    continue;
                }

                if (operand == "Add")
                {
                    jugg[row][col] += value;
                }
                else if (operand == "Subtract")
                {
                    jugg[row][col] -= value;
                }

                command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine(string.Join(" ", jugg[i]));
            }

        }
        private static bool IsCoordinatesValid(double[][] matrix, int row, int column)
        {
            if (row >= 0 && row < matrix.Length)
            {
                if (column >= 0 && column < matrix[row].Length)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
