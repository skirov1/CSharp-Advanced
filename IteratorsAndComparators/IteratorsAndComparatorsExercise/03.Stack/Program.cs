using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Stack
{
    public class Program
    {
        static void Main(string[] args)
        {
            var numbers = new CustomStack<int>();

            while (true)
            {
                var cmd = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                var action = cmd[0];
                if (action == "END")
                {
                    break;
                }
                if (action == "Push")
                {
                    var numbersToPush = new List<int>();
                    for (int i = 1; i < cmd.Length; i++)
                    {
                        numbersToPush.Add(int.Parse(cmd[i]));
                    }
                    foreach (var number in numbersToPush)
                    {
                        numbers.Push(number);
                    }
                }
                else if (action == "Pop")
                {
                    numbers.Pop();
                }
            }
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
