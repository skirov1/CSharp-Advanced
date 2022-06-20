using System;

namespace _03.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = Console.ReadLine().Split();
            var rows = int.Parse(size[0]);
            var cols = int.Parse(size[1]);
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var values = Console.ReadLine().Split();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = int.Parse(values[col]);
                }
            }

            var maxSum = long.MinValue;
            var maxRow = 0;
            var maxCol = 0;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    var currentSum = matrix[row, col] + matrix[row + 1, col] + matrix[row + 2, col] + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }
            Console.WriteLine("Sum = " + maxSum);

            for (int row = maxRow; row < maxRow + 3; row++)
            {
                for (int col = maxCol; col < maxCol + 3; col++)
                {
                    Console.Write(matrix[row,col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
