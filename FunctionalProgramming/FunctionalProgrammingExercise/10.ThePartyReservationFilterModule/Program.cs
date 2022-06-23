using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.ThePartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            var guests = Console.ReadLine().Split().ToList();

            Func<string, string, bool> startsWith = (name, text) =>
            {
                return name.StartsWith(text);
            };
            Func<string, string, bool> endsWith = (name, text) =>
            {
                return name.EndsWith(text);
            };
            Func<string, int, bool> hasLength = (name, length) =>
            {
                return name.Length == length;
            };

            var textFilters = new List<Func<string, string, bool>>();

            while (true)
            {
                var cmd = Console.ReadLine().Split(";");
                if (cmd[0] == "Print")
                {
                    break;
                }
                var action = cmd[0];
                var filter = cmd[1];
                if (action == "Add Filter")
                {
                    if (filter == "Starts with")
                    {
                        textFilters.Add(startsWith);
                    }
                }
            }
        }
    }
}
