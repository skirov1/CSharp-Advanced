using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _05.PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> numbers = new Queue<int>();
            foreach (var number in input)
            {
                if (number % 2 == 0)
                {
                    numbers.Enqueue(number);
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
