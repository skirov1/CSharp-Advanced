using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int>();
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var N = input[0];
            var S = input[1];
            var X = input[2];

            var inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            foreach (var number in inputNumbers)
            {
                numbers.Push(number);
            }
            for (int i = 0; i < S; i++)
            {
                numbers.Pop();
            }
            if (numbers.Contains(X))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (numbers.Count > 0)
                {
                    Console.WriteLine(numbers.Min());
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}
