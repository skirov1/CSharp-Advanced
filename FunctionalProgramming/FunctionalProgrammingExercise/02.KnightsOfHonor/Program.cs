using System;

namespace _02.KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> printSir = x => Console.WriteLine($"Sir {x}");
            var names = Console.ReadLine().Split();

            foreach (var name in names)
            {
                printSir(name);
            }
        }
    }
}
