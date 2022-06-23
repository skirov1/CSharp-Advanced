using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FilterByAge
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var people = new List<Person>();

            for (int i = 0; i < N; i++)
            {
                var data = Console.ReadLine().Split(", ");
                Person person = new Person();
                person.Name = data[0];
                person.Age = int.Parse(data[1]);
                people.Add(person);
            }
            var condition = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var format = Console.ReadLine();

            Func<Person, bool> filter = p => true;
            Func<Person, string> printFunc = p => p.Name + " " + p.Age;

            if (condition == "younger")
            {
                filter = p => p.Age < age;
            }
            else
            {
                filter = p => p.Age >= age;
            }
            var filteredPeople = people.Where(filter);
            if (format == "name age")
            {
                printFunc = p => p.Name + " - " + p.Age;
            }
            else if (format == "name")
            {
                printFunc = p => p.Name;
            }
            else if (format == "age")
            {
                printFunc = p => p.Age.ToString();
            }
            var printPeople = filteredPeople.Select(printFunc);
            foreach (var person in printPeople)
            {
                Console.WriteLine(person);
            }
        }        
             
    }
}
