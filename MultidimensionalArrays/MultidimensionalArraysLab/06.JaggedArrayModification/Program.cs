using System;

namespace _06.JaggedArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int[][] arrays = new int[n][];

            for (int i = 0; i < n; i++)
            {
                var newArray = Console.ReadLine().Split();
                arrays[i] = new int[newArray.Length];
                for (int j = 0; j < newArray.Length; j++)
                {
                    arrays[i][j] = int.Parse(newArray[j]);
                }
            }

            while (true)
            {
                var cmd = Console.ReadLine().Split();
                var action = cmd[0];
                if (action == "END")
                {
                    break;
                }
                var row = int.Parse(cmd[1]);
                var col = int.Parse(cmd[2]);
                var value = int.Parse(cmd[3]);
                if (row < 0 || row >= arrays.Length || col < 0  || col >= arrays[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }

                if (action == "Add")
                {
                    arrays[row][col] += value;
                }
                else if (action == "Subtract")
                {
                    arrays[row][col] -= value;
                }

            }
            foreach (var array in arrays)
            {
                Console.WriteLine(string.Join(" ", array));
            }
        }
    }
}
