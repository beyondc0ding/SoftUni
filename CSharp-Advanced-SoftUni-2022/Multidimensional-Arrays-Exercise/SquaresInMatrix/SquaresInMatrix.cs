using System;
using System.Linq;

namespace SquaresInMatrix
{
    internal class SquaresInMatrix
    {
        static void Main(string[] args)
        {
            string[] n = Console.ReadLine().Split().ToArray();

            int rows = int.Parse(n[0]);
            int cols = int.Parse(n[1]);

            string[,] matrix = new string[rows, cols];

            FillMatrix(matrix);

            int equalSquares = 0;

            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    string currentChar = matrix[row, col];

                    if (currentChar == matrix[row, col + 1] && currentChar == matrix[row + 1, col] && currentChar == matrix[row + 1, col + 1])
                        equalSquares++;
                }
            }

            Console.WriteLine(equalSquares);
        }

        private static void FillMatrix(string[,] numbers)
        {
            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                string[] rowData = Console.ReadLine().Split(" ").ToArray();
                for (int col = 0; col < numbers.GetLength(1); col++)
                {
                    numbers[row, col] = rowData[col];
                }
            }
        }
    }
}
