using System;
using System.Linq;

namespace DiagonalDifference
{
    internal class DiagonalDifference
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            fillMatrix(matrix);

            int diagonalSum1 = 0;
            int diagonalSum2 = 0;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    int number = matrix[row, col];

                    if (row == col)
                    {
                        diagonalSum1 += number;
                    }

                    if (col == n - row - 1)
                    {
                        diagonalSum2 += number;
                    }
                }
            }

            Console.WriteLine(Math.Abs(diagonalSum2 - diagonalSum1));
        }

        private static void printMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }

        private static void fillMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] currentRow = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
        }
    }
}
