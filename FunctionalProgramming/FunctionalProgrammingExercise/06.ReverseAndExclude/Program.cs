using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var n = int.Parse(Console.ReadLine());

            Func<List<int>, int, List<int>> func = IsDivisible;
            var printNumbers = func(numbers, n);
            printNumbers.Reverse();
            Console.WriteLine(string.Join(" ", printNumbers));
        }
        static List<int> IsDivisible(List<int> numbers, int n)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % n == 0)
                {
                    numbers.Remove(numbers[i]);
                    i--;
                }
            }
            return numbers;
        }

    }
}
