using System;
using System.Linq;

namespace _03.CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Func<string,bool> func = word => char.IsUpper(word[0]);
            var upperWords = text.Where(func);
            foreach (var word in upperWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}
