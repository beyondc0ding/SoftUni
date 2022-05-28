using System;
using System.Linq;

namespace MatrixShuffling
{
    class MatrixShuffling
    {
        static void Main(string[] args)
        {
            int[] dimension = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int rows = dimension[0];
            int cols = dimension[1];

            string[,] matrix = new string[rows, cols];

            fillMatrix(matrix);

            string commands = string.Empty;


            while ((commands = Console.ReadLine()) != "END")
            {
                string[] tokens = commands.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();


                if (tokens[0] == "swap" && tokens.Length == 5)
                {

                    int firstRow = int.Parse(tokens[1]);
                    int firstCol = int.Parse(tokens[2]);
                    int secondRow = int.Parse(tokens[3]);
                    int secondCol = int.Parse(tokens[4]);

                    if (firstRow >= 0 && firstRow <= rows - 1 && firstCol >= 0 && firstCol <= cols - 1
                        && secondRow >= 0 && secondRow <= rows - 1 && secondCol >= 0 && secondCol <= cols - 1)
                    {

                        var temp = matrix[firstRow, firstCol];
                        matrix[firstRow, firstCol] = matrix[secondRow, secondCol];
                        matrix[secondRow, secondCol] = temp;

                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                Console.Write($"{matrix[i, j]} ");
                            }
                            Console.WriteLine();

                        }
                    }
                    else
                    {
                        Console.WriteLine($"Invalid input!");
                    }
                }

                else
                {
                    Console.WriteLine($"Invalid input!");
                }
            }
        }

        private static void fillMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] currentRow = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
        }
    }
}