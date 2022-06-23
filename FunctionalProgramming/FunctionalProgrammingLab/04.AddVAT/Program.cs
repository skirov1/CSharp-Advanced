using System;
using System.Linq;

namespace _04.AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            var prices = Console.ReadLine().Split(", ").Select(double.Parse).ToList();
            var pricesWithVat = prices.Select(x => x *= 1.2);
            foreach (var price in pricesWithVat)
            {
                Console.WriteLine($"{price:f2}");
            }
        }
    }
}
