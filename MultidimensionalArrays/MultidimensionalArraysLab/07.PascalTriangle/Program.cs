using System;

namespace _07.PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            long[][] triangle = new long[N][];

            for (int i = 0; i < N; i++)
            {
                triangle[i] = new long[i + 1];
                triangle[i][0] = 1;
                triangle[i][triangle[i].Length - 1] = 1;
                for (int j = 1; j < triangle[i].Length - 1; j++)
                {
                    triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
                }
            }
            foreach (var item in triangle)
            {
                Console.WriteLine(string.Join(" ", item));
            }
        }
    }
}
