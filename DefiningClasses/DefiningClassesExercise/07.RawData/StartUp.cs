using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < N; i++)
            {
                var data = Console.ReadLine().Split();

                var model = data[0];
                var engineSpeed = int.Parse(data[1]);
                var enginePower = int.Parse(data[2]);
                var cargoWeight = int.Parse(data[3]);
                var cargoType = data[4];
                var tire1Pressure = double.Parse(data[5]);
                var tire1Age = int.Parse(data[6]);
                var tire2Pressure = double.Parse(data[7]);
                var tire2Age = int.Parse(data[8]);
                var tire3Pressure = double.Parse(data[9]);
                var tire3Age = int.Parse(data[10]);
                var tire4Pressure = double.Parse(data[11]);
                var tire4Age = int.Parse(data[12]);
                Car car = new Car(model, engineSpeed, enginePower, cargoWeight, cargoType, tire1Pressure, tire1Age, tire2Pressure, tire2Age, tire3Pressure, tire3Age, tire4Pressure, tire4Age);
                cars.Add(car);
            }
            var cargo = Console.ReadLine();

            Print(cargo, cars);
        }
        static void Print(string cargoType, List<Car> cars)
        {
            if (cargoType == "fragile")
            {
                var print = true;
                foreach (var car in cars)
                {
                    if (car.Cargo.Type == cargoType)
                    {
                        foreach (var tire in car.Tires)
                        {
                            if (tire.Pressure < 1)
                            {
                                print = true;
                            }
                            else
                            {
                                print = false;
                                break;
                            }
                        }
                    }
                    if (print)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
            else if (cargoType == "flammable")
            {
                foreach (var car in cars)
                {
                    if (car.Cargo.Type == cargoType && car.Engine.Power > 250)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
        }
    }
}
