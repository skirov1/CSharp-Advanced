using System;

namespace _02.SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = Console.ReadLine().Split();
            var rows = int.Parse(size[0]);
            var cols = int.Parse(size[1]);
            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var values = Console.ReadLine().Split();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = char.Parse(values[col]);
                }
            }

            var count = 0;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[row, col] == matrix[row + 1, col] && matrix[row + 1, col] == matrix[row, col + 1] && matrix[row, col + 1] == matrix[row + 1, col + 1])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
