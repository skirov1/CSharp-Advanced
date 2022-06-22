using System;
using System.Collections.Generic;

namespace _07.ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> cars = new HashSet<string>();

            while (true)
            {
                var data = Console.ReadLine().Split(", ");
                if (data[0] == "END")
                {
                    break;
                }
                if (data[0] == "IN")
                {
                    cars.Add(data[1]);
                }
                else if (data[0] == "OUT")
                {
                    cars.Remove(data[1]);
                }
            }
            if (cars.Count > 0)
            {
                foreach (var car in cars)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            
        }
    }
}
