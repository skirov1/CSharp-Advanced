using System;

namespace _07.Tuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            var personData = Console.ReadLine().Split();
            var beerPersonData = Console.ReadLine().Split();
            var numbersData = Console.ReadLine().Split();

            var name = personData[0] + " " + personData[1];
            var address = personData[2];
            var person = new Tuple<string, string>(name, address);

            var beerPersonName = beerPersonData[0];
            var beersCount = int.Parse(beerPersonData[1]);
            var beerPerson = new Tuple<string, int>(beerPersonName, beersCount);

            var number = int.Parse(numbersData[0]);
            var floatNumber = double.Parse(numbersData[1]);
            var numbers = new Tuple<int, double>(number, floatNumber);

            Console.WriteLine($"{person.Item1} -> {person.Item2}");
            Console.WriteLine($"{beerPerson.Item1} -> {beerPerson.Item2}");
            Console.WriteLine($"{numbers.Item1} -> {numbers.Item2}");
        }
    }
}
