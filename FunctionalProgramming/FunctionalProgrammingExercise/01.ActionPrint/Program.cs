using System;
using System.Linq;

namespace _01.ActionPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> print = p => Console.WriteLine(p);

            var data = Console.ReadLine().Split();

            foreach (var name in data)
            {
                print(name);
            }
        }
    }
}
