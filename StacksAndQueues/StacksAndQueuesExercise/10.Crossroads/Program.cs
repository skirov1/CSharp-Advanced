using System;
using System.Collections;
using System.Collections.Generic;

namespace _10.Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            var greenLightSeconds = int.Parse(Console.ReadLine());
            var freeWindowSeconds = int.Parse(Console.ReadLine());
            int totalTime;
            var carsPassed = 0;
            Queue<string> cars = new Queue<string>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                totalTime = greenLightSeconds + freeWindowSeconds;
                if (input != "green")
                {
                    cars.Enqueue(input);
                }
                else if (input == "green")
                {
                    while (totalTime - freeWindowSeconds > 0 && cars.Count > 0)
                    {
                        var currentCar = cars.Peek();
                        if (currentCar.Length <= totalTime)
                        {
                            totalTime -= currentCar.Length;                            
                            carsPassed++;
                            cars.Dequeue();
                        }
                        else
                        {
                            var hitIndex = totalTime;
                            Console.WriteLine("A crash happened!");
                            Console.WriteLine($"{currentCar} was hit at {currentCar[hitIndex]}.");
                            return;
                        }
                    }
                }
            }
            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{carsPassed} total cars passed the crossroads.");
        }
    }
}
