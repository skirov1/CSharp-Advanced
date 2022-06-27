using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Froggy
{
    public class Program
    {
        static void Main(string[] args)
        {
            var stones = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
            var lake = new Lake(stones);
            var print = new List<int>();
            foreach (var stone in lake)
            {
                print.Add(stone);
            }
            Console.WriteLine(string.Join(", ", print));
        }
    }
}
