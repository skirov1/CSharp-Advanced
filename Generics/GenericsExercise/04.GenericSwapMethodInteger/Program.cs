using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.GenericSwapMethodInteger
{
    public class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var list = new List<int>();
            for (int i = 0; i < N; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }
            var indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var index1 = indexes[0];
            var index2 = indexes[1];
            Swap(list, index1, index2);
            foreach (var item in list)
            {
                Console.WriteLine($"{item.GetType()}: {item}");
            }
        }
        static void Swap<T>(List<T> list, int index1, int index2)
        {
            var temp = list[index1];
            list[index1] = list[index2];
            list[index2] = temp;
        }
    }
}

