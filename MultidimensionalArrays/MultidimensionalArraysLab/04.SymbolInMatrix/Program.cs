using System;
using System.Linq;

namespace _04.SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            var matrix = new char[size, size];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var column = Console.ReadLine();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = column[j];
                }
            }
            var symbol = char.Parse(Console.ReadLine());
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j] == symbol)
                    {
                        Console.WriteLine($"({i}, {j})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{symbol} does not occur in the matrix");
        }
    }
}
