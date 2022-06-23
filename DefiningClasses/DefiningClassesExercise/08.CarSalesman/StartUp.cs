using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();
            var N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                Engine engine = new Engine();
                var data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var engineModel = data[0];
                var power = int.Parse(data[1]);
                if (data.Length == 3)
                {
                    var sth = data[2];
                    int number;
                    if (int.TryParse(sth, out number))
                    {
                        engine.Displacement = int.Parse(sth);
                    }
                    else
                    {
                        engine.Efficiency = sth;
                    }
                }
                else if (data.Length == 4)
                {
                    var displacement = int.Parse(data[2]);
                    var efficiency = data[3];
                    engine.Displacement = displacement;
                    engine.Efficiency = efficiency;
                }

                engine.Model = engineModel;
                engine.Power = power;
                engines.Add(engine);
            }
            var M = int.Parse(Console.ReadLine());
            for (int i = 0; i < M; i++)
            {
                Car car = new Car();
                var data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var model = data[0];
                var engineModel = data[1];
                if (data.Length == 3)
                {
                    var sth = data[2];
                    int number;
                    if (int.TryParse(sth, out number))
                    {
                        car.Weight = int.Parse(sth);
                    }
                    else
                    {
                        car.Color = sth;
                    }
                }
                else if (data.Length == 4)
                {
                    var weight = int.Parse(data[2]);
                    var color = data[3];
                    car.Weight = weight;
                    car.Color = color;
                }
                car.Model = model;
                foreach (var engine in engines)
                {
                    if (engine.Model == engineModel)
                    {
                        car.Engine = engine;
                    }
                }
                cars.Add(car);
            }
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine.Model}:");
                Console.WriteLine($"    Power: {car.Engine.Power}");
                if (car.Engine.Displacement != 0)
                {
                    Console.WriteLine($"    Displacement: {car.Engine.Displacement}");
                }
                else
                {
                    Console.WriteLine($"    Displacement: n/a");
                }
                if (car.Engine.Efficiency != null)
                {
                    Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
                }
                else
                {
                    Console.WriteLine($"    Efficiency: n/a");
                }
                if (car.Weight != 0)
                {
                    Console.WriteLine($"  Weight: {car.Weight}");
                }
                else
                {
                    Console.WriteLine($"  Weight: n/a");
                }
                if (car.Color != null)
                {
                    Console.WriteLine($"  Color: {car.Color}");
                }
                else
                {
                    Console.WriteLine($"  Color: n/a");
                }
            }

            //foreach (var car in cars)
            //{
            //    console.writeline(car.tostring());
            //}
        }
    }
}
