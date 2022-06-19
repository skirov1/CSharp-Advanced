using System;
using System.Collections.Generic;

namespace _03.SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            Stack<string> operations = new Stack<string>();
            var result = 0;
            foreach (var item in input)
            {
                operations.Push(item);
            }
            Stack<string> reversedOperations = new Stack<string>();
            while (operations.Count > 0)
            {
                reversedOperations.Push(operations.Pop());
            }

            while (reversedOperations.Count > 0)
            {
                if (reversedOperations.Peek() == "+")
                {
                    reversedOperations.Pop();
                    result += int.Parse(reversedOperations.Pop());
                }
                else if (reversedOperations.Peek() == "-")
                {
                    reversedOperations.Pop();
                    result -= int.Parse(reversedOperations.Pop());
                }
                else
                {
                    result += int.Parse(reversedOperations.Pop());
                }
            }
            Console.WriteLine(result);
        }
    }
}
