using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            List<Tire[]> tires = new List<Tire[]>();
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();
            while (true)
            {
                var cmd = Console.ReadLine();
                if (cmd == "No more tires")
                {
                    break;
                }
                var data = cmd.Split().Select(double.Parse).ToArray();
                var tire1 = new Tire(data[0], data[1]);
                var tire2 = new Tire(data[2], data[3]);
                var tire3 = new Tire(data[4], data[5]);
                var tire4 = new Tire(data[6], data[7]);
                Tire[] tiresData = new Tire[4] { tire1, tire2, tire3, tire4 };
                tires.Add(tiresData);
            }
            while (true)
            {
                var cmd = Console.ReadLine();
                if (cmd == "Engines done")
                {
                    break;
                }
                var data = cmd.Split().Select(double.Parse).ToArray();
                var engine = new Engine(data[0], data[1]);
                engines.Add(engine);
            } 
            while (true)
            {
                var cmd = Console.ReadLine();
                if (cmd == "Show special")
                {
                    break;
                }
                var data = cmd.Split();
                var make = data[0];
                var model = data[1];
                var year = int.Parse(data[2]);
                var fuelQuantity = double.Parse(data[3]);
                var fuelConsumption = double.Parse(data[4]);
                var engineIndex = int.Parse(data[5]);
                var tireIndex = int.Parse(data[6]);

                var car = new Car(make, model, year, fuelQuantity, fuelConsumption, engines[engineIndex], tires[tireIndex]);

                cars.Add(car);
            }

            foreach (var car in cars)
            {
                var tiresSum = 0.0;
                foreach (var tire in car.Tires)
                {
                    tiresSum += tire.Pressure;
                }
                if (car.Year >= 2017 && car.Engine.HorsePower > 330 && tiresSum >= 9 && tiresSum <= 10)
                {
                    car.Drive(20);
                    Console.WriteLine($"Make: {car.Make}");
                    Console.WriteLine($"Model: {car.Model}");
                    Console.WriteLine($"Year: {car.Year}");
                    Console.WriteLine($"HorsePowers: {car.Engine.HorsePower}");
                    Console.WriteLine($"FuelQuantity: {car.FuelQuantity}");
                }
            }
        }
    }
}
