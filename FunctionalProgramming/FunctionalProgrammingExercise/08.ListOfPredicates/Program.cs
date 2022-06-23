using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var numbers = Enumerable.Range(1, N).ToList();
            var dividers = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<Predicate<int>> predicates = new List<Predicate<int>>();

            foreach (var number in dividers)
            {
                predicates.Add(x => x % number == 0);
            }
            foreach (var number in numbers)
            {
                bool isDiv = true;
                foreach (var predicate in predicates)
                {
                    if (!predicate(number))
                    {
                        isDiv = false;
                        break;
                    }
                }
                if (isDiv)
                {
                    Console.Write(number + " ");
                }
            }
        }
    }
}
