using System;
using System.Collections.Generic;

namespace _06.GenericCountMethodDouble
{
    public class Program
    {
        static void Main(string[] args)
        {
            var box = new Box<double>();
            var list = new List<double>();
            var N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                list.Add(double.Parse(Console.ReadLine()));
            }
            var element = double.Parse(Console.ReadLine());
            Console.WriteLine(box.Count(list, element));
        }
    }
}
