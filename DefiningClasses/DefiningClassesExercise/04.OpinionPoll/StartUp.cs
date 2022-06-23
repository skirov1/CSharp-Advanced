using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var people = new List<Person>();

            for (int i = 0; i < N; i++)
            {
                var data = Console.ReadLine().Split();
                var name = data[0];
                var age = int.Parse(data[1]);
                if (age > 30)
                {
                    var person = new Person(name, age);
                    people.Add(person);
                }
            }
            people = people.OrderBy(x => x.Name).ToList();
            foreach (var person in people)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }

        }
    }
}
