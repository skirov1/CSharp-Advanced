using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TheVLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            var Vlogger = new Dictionary<string, Dictionary<string, List<string>>>();

            while (true)
            {
                var data = Console.ReadLine().Split();
                if (data[0] == "Statistics")
                {
                    break;
                }
                var action = data[1];
                if (action == "joined")
                {
                    var vloggerName = data[0];
                    if (!Vlogger.ContainsKey(vloggerName))
                    {
                        Vlogger.Add(vloggerName, new Dictionary<string, List<string>>());
                        Vlogger[vloggerName].Add("following", new List<string>());
                        Vlogger[vloggerName].Add("followers", new List<string>());
                    }
                }
                else if (action == "followed")
                {
                    var vlogger1 = data[0];
                    var vlogger2 = data[2];
                    if (Vlogger.ContainsKey(vlogger1) && Vlogger.ContainsKey(vlogger2) && vlogger1 != vlogger2 && !Vlogger[vlogger1]["following"].Contains(vlogger2))
                    {
                        Vlogger[vlogger1]["following"].Add(vlogger2);
                        Vlogger[vlogger2]["followers"].Add(vlogger1);
                    }
                }
            }
            Console.WriteLine($"The V-Logger has a total of {Vlogger.Count} vloggers in its logs.");
            var mostFamousVlogger = string.Empty;
            var mostFamousVloggerFollowers = long.MinValue;
            foreach (var vlogger in Vlogger)
            {
                foreach (var stat in vlogger.Value)
                {
                    if (stat.Key == "followers" && stat.Value.Count > mostFamousVloggerFollowers)
                    {
                        mostFamousVlogger = vlogger.Key;
                        mostFamousVloggerFollowers = stat.Value.Count;
                    }
                    else if (stat.Key == "followers" && stat.Value.Count == mostFamousVloggerFollowers)
                    {
                        if (Vlogger[vlogger.Key]["following"].Count < Vlogger[mostFamousVlogger]["following"].Count)
                        {
                            mostFamousVlogger = vlogger.Key;
                            mostFamousVloggerFollowers = stat.Value.Count;
                        }
                    }
                }
            }
           
            Console.WriteLine($"1. {mostFamousVlogger} : {mostFamousVloggerFollowers} followers, {Vlogger[mostFamousVlogger]["following"].Count} following");
            if (Vlogger[mostFamousVlogger]["followers"].Count > 0)
            {
                foreach (var follower in Vlogger[mostFamousVlogger]["followers"].OrderBy(x => x))
                {
                    Console.WriteLine($"*  {follower}");
                }
            }
            Vlogger.Remove(mostFamousVlogger);
            Vlogger = Vlogger.OrderByDescending(x => x.Value["followers"].Count).ThenBy(x => x.Value["following"].Count).ToDictionary(x => x.Key, x => x.Value);
            var row = 2;
            foreach (var vlogger in Vlogger)
            {
                Console.WriteLine($"{row}. {vlogger.Key} : {vlogger.Value["followers"].Count} followers, {vlogger.Value["following"].Count} following");
                row++;
            }
        }
    }
}
