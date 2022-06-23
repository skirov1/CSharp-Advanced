using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Func<List<int>, List<int>> add = Add;
            //Func<List<int>, List<int>> multiply = Multiply;
            // Func<List<int>, List<int>> subtract = Subtract;
            //  Func<List<int>, string> print = Print;

            Action<List<int>> print = x => Console.WriteLine(string.Join(" ", x));
            Action<List<int>> add = numbers =>
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        numbers[i]++;
                    }
                };
            Action<List<int>> multiply = numbers =>
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    numbers[i]*=2;
                }
            };
            Action<List<int>> subtract = numbers =>
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    numbers[i]--;
                }
            };

            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                var cmd = Console.ReadLine();
                if (cmd == "end")
                {
                    End();
                }
                if (cmd == "add")
                {
                    add(numbers);
                }
                else if (cmd == "multiply")
                {
                    multiply(numbers);
                }
                else if (cmd == "subtract")
                {
                    subtract(numbers);
                }
                else if (cmd == "print")
                {
                    print(numbers);
                }
            }
        }
        
        static void End()
        {
            Environment.Exit(0);
        }
    }
}
