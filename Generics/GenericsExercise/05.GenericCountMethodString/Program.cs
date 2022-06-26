using System;
using System.Collections.Generic;

namespace _05.GenericCountMethodString
{
    public class Program
    {
        static void Main(string[] args)
        {
            var box = new Box<string>();
            var list = new List<string>();
            var N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                list.Add(Console.ReadLine());
            }
            var element = Console.ReadLine();
            Console.WriteLine(box.Count(list, element));
        }

    }
}
