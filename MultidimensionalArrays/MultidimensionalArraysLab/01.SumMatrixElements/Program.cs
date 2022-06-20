using System;

namespace _01.SumMatrixElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var rowsAndCols = Console.ReadLine().Split(", ");
            var rows = int.Parse(rowsAndCols[0]);
            var cols = int.Parse(rowsAndCols[1]);
            int[,] matrix = new int[rows, cols];
            var sum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var column = Console.ReadLine().Split(", ");
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = int.Parse(column[j]);
                    sum += int.Parse(column[j]);
                }
            }
            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sum);
        }
    }
}
