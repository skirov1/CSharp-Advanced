using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split().ToList();
            Func<string, int, bool> isValid = (name, length) => name.Length <= length;

            var result = names.Where(x => isValid(x, n)).ToList();

            Console.WriteLine(string.Join("\n", result));
        }
        
    }
}
