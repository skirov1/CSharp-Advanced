using System;
using System.Linq;

namespace _04.FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> isEven = x => x % 2 == 0;
            Predicate<int> isOdd = x => x % 2 != 0;

            var range = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var condition = Console.ReadLine();

            for (int i = range[0]; i <= range[1]; i++)
            {
                if (condition == "odd")
                {
                    if (isOdd(i))
                    {
                        Console.Write(i + " ");
                    }
                }
                else
                {
                    if (isEven(i))
                    {
                        Console.Write(i + " ");
                    }
                }
            }
        }
    }
}

