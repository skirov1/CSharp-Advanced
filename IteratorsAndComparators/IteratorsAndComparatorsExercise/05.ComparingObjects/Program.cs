using System;
using System.Collections.Generic;

namespace _05.ComparingObjects
{
    public class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>();
            while (true)
            {
                var data = Console.ReadLine().Split();
                if (data[0] == "END")
                {
                    break;
                }
                var name = data[0];
                var age = int.Parse(data[1]);
                var town = data[2];
                var person = new Person(name, age, town);
                people.Add(person);
            }
            var index = int.Parse(Console.ReadLine());

            var currentPerson = people[index - 1];

            foreach (var person in people)
            {            
                if (currentPerson.CompareTo(person) == 0)
                {
                    currentPerson.Matches++;
                }
            }
            if (currentPerson.Matches > 1)
            {
                Console.WriteLine($"{currentPerson.Matches} {people.Count - currentPerson.Matches} {people.Count}");
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
    }
}
