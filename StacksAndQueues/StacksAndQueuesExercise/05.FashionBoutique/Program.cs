using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            var clothesValues = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var capacity = int.Parse(Console.ReadLine());
            var clothes = new Stack<int>();
            var numberOfRacks = 1;
            var clothesSum = 0;

            foreach (var cloth in clothesValues)
            {
                clothes.Push(cloth);
            }

            while (clothes.Count > 0)
            {
                if (clothesSum + clothes.Peek() > capacity)
                {
                    numberOfRacks++;
                    clothesSum = 0;
                }
                else
                {
                    clothesSum += clothes.Pop();
                }
            }
            Console.WriteLine(numberOfRacks);
        }
    }
}
