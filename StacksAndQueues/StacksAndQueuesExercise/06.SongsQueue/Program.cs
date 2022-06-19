using System;
using System.Collections.Generic;

namespace _06.SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            var songsInput = Console.ReadLine().Split(", ");
            var songs = new Queue<string>();
            foreach (var song in songsInput)
            {
                songs.Enqueue(song);
            }

            while (songs.Count > 0)
            {
                var cmd = Console.ReadLine();
                if (cmd == "Play")
                {
                    songs.Dequeue();
                }
                else if (cmd == "Show")
                {
                    Console.WriteLine(string.Join(", ", songs));
                }
                else
                {
                    var song = string.Empty;
                    for (int i = 4; i < cmd.Length; i++)
                    {
                        song += cmd[i];
                    }
                    if (!songs.Contains(song))
                    {
                        songs.Enqueue(song);
                    }
                    else
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
