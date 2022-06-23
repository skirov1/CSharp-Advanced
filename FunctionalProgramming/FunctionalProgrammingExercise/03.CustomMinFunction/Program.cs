using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<List<int>, int> FindSmallest = FindMin;
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            Console.WriteLine(FindSmallest(numbers));
        }
        static int FindMin(List<int> numbers)
        {
            var min = int.MaxValue;
            foreach (var number in numbers)
            {
                if (number < min)
                {
                    min = number;
                }
            }
            return min;
        }
    }
}
