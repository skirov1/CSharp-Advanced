using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.PredicateParty_
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

            while (true)
            {
                var cmd = Console.ReadLine().Split();
                if (cmd[0] == "Party!")
                {
                    break;
                }
                var action = cmd[0];
                var condition = cmd[1];

                if (action == "Remove")
                {
                    if (condition == "StartsWith")
                    {
                        var text = cmd[2];
                        for (int i = 0; i < guests.Count; i++)
                        {
                            if (startsWith(guests[i], text))
                            {
                                guests.Remove(guests[i]);
                                i--;
                            }
                        }
                    }
                    else if (condition == "EndsWith")
                    {
                        var text = cmd[2];
                        for (int i = 0; i < guests.Count; i++)
                        {
                            if (endsWith(guests[i], text))
                            {
                                guests.Remove(guests[i]);
                                i--;
                            }
                        }
                    }
                    else if (condition == "Length")
                    {
                        var length = int.Parse(cmd[2]);
                        for (int i = 0; i < guests.Count; i++)
                        {
                            if (hasLength(guests[i], length))
                            {
                                guests.Remove(guests[i]);
                                i--;
                            }
                        }
                    }
                }
                else if (action == "Double")
                {
                    if (condition == "StartsWith")
                    {
                        var text = cmd[2];
                        for (int i = 0; i < guests.Count; i++)
                        {
                            if (startsWith(guests[i], text))
                            {
                                guests.Add(guests[i]);
                                i++;
                            }
                        }
                    }
                    else if (condition == "EndsWith")
                    {
                        var text = cmd[2];
                        for (int i = 0; i < guests.Count; i++)
                        {
                            if (endsWith(guests[i], text))
                            {
                                guests.Add(guests[i]);
                                i++;
                            }
                        }
                    }
                    else if (condition == "Length")
                    {
                        var length = int.Parse(cmd[2]);
                        for (int i = 0; i < guests.Count; i++)
                        {
                            if (hasLength(guests[i], length))
                            {
                                guests.Insert(i + 1, guests[i]);
                                i++;
                            }
                        }
                    }
                }
            }
            if (guests.Count > 0)
            {
                Console.WriteLine($"{string.Join(", ", guests)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
    }
}
