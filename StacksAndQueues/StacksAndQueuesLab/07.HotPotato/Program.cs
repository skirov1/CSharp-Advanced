using System;
using System.Collections.Generic;

namespace _07.HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split();
            var n = int.Parse(Console.ReadLine());
            Queue<string> people = new Queue<string>();
            foreach (var name in names)
            {
                people.Enqueue(name);
            }

            while (people.Count > 1)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    var person = people.Dequeue();
                    people.Enqueue(person);
                }

                var personToRemove = people.Dequeue();
                Console.WriteLine($"Removed {personToRemove}");
            }
            Console.WriteLine($"Last is {people.Dequeue()}");
        }
    }
}
