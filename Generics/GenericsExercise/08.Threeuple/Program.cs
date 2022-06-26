using System;

namespace _08.Threeuple
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
            var town = personData[3];
            if (personData.Length > 4)
            {
                town += " " + personData[4];
            }
            var person = new Tuple<string, string, string>(name, address, town);

            var beerPersonName = beerPersonData[0];
            var beersCount = int.Parse(beerPersonData[1]);
            var drinkOrNotInput = beerPersonData[2];
            var drunkOrNot = false;
            if (drinkOrNotInput == "drunk")
            {
                drunkOrNot = true;
            }
            var beerPerson = new Tuple<string, int, bool>(beerPersonName, beersCount, drunkOrNot);

            var accountName = numbersData[0];
            var accountBalance = double.Parse(numbersData[1]);
            var bankName =numbersData[2];
            var bankInfo = new Tuple<string, double, string>(accountName, accountBalance, bankName);

            Console.WriteLine($"{person.Item1} -> {person.Item2} -> {person.Item3}");
            Console.WriteLine($"{beerPerson.Item1} -> {beerPerson.Item2} -> {beerPerson.Item3}");
            Console.WriteLine($"{bankInfo.Item1} -> {bankInfo.Item2} -> {bankInfo.Item3}");
        }
    }
}
