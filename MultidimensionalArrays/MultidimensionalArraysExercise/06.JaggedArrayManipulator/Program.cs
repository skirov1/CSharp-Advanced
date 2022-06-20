using System;

namespace _06.JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            double[][] matrix = new double[N][];

            for (int row = 0; row < N; row++)
            {
                var values = Console.ReadLine().Split();
                matrix[row] = new double[values.Length];
                for (int j = 0; j < matrix[row].Length; j++)
                {
                    matrix[row][j] = int.Parse(values[j]);
                }
            }

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                if (matrix[row].Length == matrix[row + 1].Length)
                {
                    for (int j = 0; j < matrix[row].Length; j++)
                    {
                        matrix[row][j] *= 2;
                        matrix[row + 1][j] *= 2;
                    }
                }
                else
                {
                    for (int j = 0; j < matrix[row].Length; j++)
                    {
                        matrix[row][j] /= 2;
                    }
                    for (int j = 0; j < matrix[row + 1].Length; j++)
                    {
                        matrix[row + 1][j] /= 2;
                    }
                }
            }

            while (true)
            {
                var cmd = Console.ReadLine().Split();
                var action = cmd[0];

                if (action == "End")
                {
                    break;
                }

                var row = int.Parse(cmd[1]);
                var col = int.Parse(cmd[2]);
                var value = int.Parse(cmd[3]);

                if (action == "Add" && row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix[row].Length)
                {
                    matrix[row][col] += value;
                }
                else if (action == "Subtract" && row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix[row].Length)
                {
                    matrix[row][col] -= value;
                }
            }

            foreach (var arr in matrix)
            {
                Console.WriteLine(string.Join(" ", arr));
            }
        }
    }
}
