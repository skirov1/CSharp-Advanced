using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfLines = int.Parse(Console.ReadLine());
            Stack<int> numbers = new Stack<int>();
            for (int i = 0; i < numberOfLines; i++)
            {
                var cmd = Console.ReadLine().Split().Select(int.Parse).ToArray();
                var action = cmd[0];
                if (action == 1)
                {
                    var number = cmd[1];
                    numbers.Push(number);
                }
                else if (action == 2)
                {
                    numbers.Pop();
                }
                else if (action == 3)
                {
                    if (numbers.Count > 0)
                    {
                        Console.WriteLine(numbers.Max());
                    }
                }
                else if (action == 4)
                {
                    if (numbers.Count > 0)
                    {
                        Console.WriteLine(numbers.Min());
                    }
                }
            }
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
