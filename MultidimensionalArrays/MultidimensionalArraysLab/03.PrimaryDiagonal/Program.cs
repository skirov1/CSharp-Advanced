using System;
using System.Linq;

namespace _03.PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            var matrix = new int[size, size];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var column = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = column[j];
                }
            }
            var diagonalSum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {           
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    diagonalSum += matrix[i, j];
                    i++;
                }
            }
            Console.WriteLine(diagonalSum);
        }
    }
}
