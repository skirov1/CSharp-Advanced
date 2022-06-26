using System;

namespace _01.GenericBoxOfString
{
    public class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var box = new Box<string>();
                box.Value = Console.ReadLine();
                Console.WriteLine(box.ToString());
            }
        }
    }
}
