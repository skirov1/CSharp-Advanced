using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var pumps = new Queue<int[]>();

            for (int i = 0; i < N; i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                var petrol = input[0];
                var distance = input[1];
                pumps.Enqueue(new int[] { petrol, distance });
            }
            var startIndex = 0;
            while (true)
            {
                var currentPetrol = 0;
                foreach (var pump in pumps)
                {
                    var truckPetrol = pump[0];
                    var truckDistance = pump[1];
                    currentPetrol += truckPetrol;
                    currentPetrol -= truckDistance;
                    if (currentPetrol < 0)
                    {
                        var currentPump = pumps.Dequeue();
                        pumps.Enqueue(currentPump);
                        startIndex++;
                        break;
                    }
                }
                if (currentPetrol >= 0)
                {
                    Console.WriteLine(startIndex);
                    return;
                }
            }
        }
    }
}
