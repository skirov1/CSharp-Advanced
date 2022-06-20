using System;
using System.Linq;

namespace _02.SumMatrixColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = Console.ReadLine().Split(", ");
            var rows = int.Parse(size[0]);
            var cols = int.Parse(size[1]);
            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var column = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = column[j];
                }
            }
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                var currentSum = 0;
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    currentSum += matrix[j, i];
                }
                Console.WriteLine(currentSum);
            }
        }
    }
}
