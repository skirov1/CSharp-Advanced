using System;
using System.Collections.Generic;

namespace _06.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            var clothes = new Dictionary<string, Dictionary<string, int>>();
            var N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                var data = Console.ReadLine().Split(" -> ");
                var color = data[0];
                var clothesData = data[1].Split(",");
                for (int j = 0; j < clothesData.Length; j++)
                {
                    var currentCloth = clothesData[j];
                    if (!clothes.ContainsKey(color))
                    {
                        clothes.Add(color, new Dictionary<string, int>());
                    }
                    if (!clothes[color].ContainsKey(currentCloth))
                    {
                        clothes[color].Add(currentCloth, 0);
                    }
                    clothes[color][currentCloth]++;
                }
            }
            var input = Console.ReadLine().Split();
            var searchedColor = input[0];
            var searchedCloth = input[1];

            foreach (var color in clothes)
            {
                Console.WriteLine($"{color.Key} clothes:");
                foreach (var cloth in color.Value)
                {
                    if (color.Key == searchedColor && cloth.Key == searchedCloth)
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                    }
                    else
                    { 
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                    }
                }
            }
        }
    }
}
