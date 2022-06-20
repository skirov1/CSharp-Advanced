using System;

namespace _04.MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = Console.ReadLine().Split();
            var rows = int.Parse(size[0]);
            var cols = int.Parse(size[1]);
            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var values = Console.ReadLine().Split();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = values[col];
                }
            }

            while (true)
            {
                var cmd = Console.ReadLine().Split();
                if (cmd[0] == "END")
                {
                    break;
                }
                if (cmd[0] == "swap" && cmd.Length == 5)
                {
                    var row1 = int.Parse(cmd[1]);
                    var col1 = int.Parse(cmd[2]);
                    var row2 = int.Parse(cmd[3]);
                    var col2 = int.Parse(cmd[4]);

                    if (row1 < 0 || row1 >= matrix.GetLength(0) || row2 < 0 || row2 >= matrix.GetLength(0) || col1 < 0 || col1 >= matrix.GetLength(1) || col2 < 0 || col2 >= matrix.GetLength(1))
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    else
                    {
                        var temp = matrix[row1, col1];
                        matrix[row1, col1] = matrix[row2, col2];
                        matrix[row2, col2] = temp;

                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                Console.Write(matrix[row, col] + " ");
                            }
                            Console.WriteLine();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
    }
}
