using System;
using System.Collections.Generic;

namespace _04.ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> shops = new SortedDictionary<string, Dictionary<string, double>>();

            while (true)
            {
                var data = Console.ReadLine().Split(", ");
                if (data[0] == "Revision")
                {
                    break;
                }
                var store = data[0];
                var product = data[1];
                var price = double.Parse(data[2]);

                if (!shops.ContainsKey(store))
                {
                    shops.Add(store, new Dictionary<string, double>());
                }
                shops[store].Add(product, price);
            }

            foreach (var shop in shops)
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
