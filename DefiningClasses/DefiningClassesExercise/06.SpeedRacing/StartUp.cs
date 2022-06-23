using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var cars = new List<Car>();
            for (int i = 0; i < N; i++)
            {
                var data = Console.ReadLine().Split();
                var model = data[0];
                var fuelAmount = double.Parse(data[1]);
                var fuelConsumptionPerKilometer = double.Parse(data[2]);
                var car = new Car(model, fuelAmount, fuelConsumptionPerKilometer);
                cars.Add(car);
            }
            while (true)
            {
                var cmd = Console.ReadLine().Split();
                if (cmd[0] == "End")
                {
                    break;
                }
                var model = cmd[1];
                var distance = double.Parse(cmd[2]);
                foreach (var car in cars)
                {
                    if (car.Model == model)
                    {
                        car.Drive(distance);
                    }
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
