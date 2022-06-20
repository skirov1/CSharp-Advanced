using System;

namespace _01.DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            int[,] matrix = new int[N, N];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var values = Console.ReadLine().Split();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = int.Parse(values[col]);
                }
            }
            var primaryDiaognalSum = 0;
            var secondaryDiaognalSum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    primaryDiaognalSum += matrix[row, col];
                    row++;
                }
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                {
                    secondaryDiaognalSum += matrix[row, col];
                    row++;
                }
            }
            Console.WriteLine(Math.Abs(primaryDiaognalSum - secondaryDiaognalSum));

        }
    }
}
