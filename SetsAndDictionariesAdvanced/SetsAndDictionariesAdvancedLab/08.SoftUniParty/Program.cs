using System;
using System.Collections.Generic;

namespace _08.SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> guests = new HashSet<string>();
            HashSet<string> VIPguests = new HashSet<string>();

            while (true)
            {
                var data = Console.ReadLine();
                if (data == "PARTY")
                {
                    break;
                }
                if (char.IsDigit(data[0]))
                {
                    VIPguests.Add(data);
                }
                else
                {
                    guests.Add(data);
                }
            }
            while (true)
            {
                var data = Console.ReadLine();
                if (data == "END")
                {
                    break;
                }
                if (char.IsDigit(data[0]) && VIPguests.Contains(data))
                {
                    VIPguests.Remove(data);
                }
                else
                {
                    if (guests.Contains(data))
                    {
                        guests.Remove(data);
                    }
                }
            }
            Console.WriteLine(VIPguests.Count + guests.Count);
            foreach (var vip in VIPguests)
            {
                Console.WriteLine(vip);
            }
            foreach (var guest in guests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
