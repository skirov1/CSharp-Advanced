using System;
using System.Collections.Generic;

namespace _02.SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var NandM = Console.ReadLine().Split();
            var N = int.Parse(NandM[0]);
            var M = int.Parse(NandM[1]);
            HashSet<int> set1 = new HashSet<int>();
            HashSet<int> set2 = new HashSet<int>();
            HashSet<int> resultSet = new HashSet<int>();

            for (int i = 0; i < N; i++)
            {
                set1.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < M; i++)
            {
                set2.Add(int.Parse(Console.ReadLine()));
            }

            foreach (var number in set1)
            {
                if (set2.Contains(number))
                {
                    resultSet.Add(number);
                }
            }

            Console.WriteLine(string.Join(" ", resultSet));
        }
    }
}
