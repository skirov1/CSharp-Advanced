using System;
using System.Collections.Generic;

namespace _02.StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int>();
            var numbersInput = Console.ReadLine().Split();
            foreach (var number in numbersInput)
            {
                numbers.Push(int.Parse(number));
            }

            while (true)
            {
                var cmd = Console.ReadLine().Split();
                var action = cmd[0].ToLower();
                if (action == "end")
                {
                    break;
                }
                else if (action == "add")
                {
                    numbers.Push(int.Parse(cmd[1]));
                    numbers.Push(int.Parse(cmd[2]));
                }
                else if (action == "remove")
                {
                    if (int.Parse(cmd[1]) <= numbers.Count)
                    {
                        for (int i = 0; i < int.Parse(cmd[1]); i++)
                        {
                            numbers.Pop();
                        }
                    }
                }
            }
            int sum = 0;
            foreach (var item in numbers)
            {
                sum += item;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
