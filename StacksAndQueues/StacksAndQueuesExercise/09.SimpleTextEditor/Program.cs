using System;
using System.Collections.Generic;
using System.Text;

namespace _09.SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var currentStringToAdd = string.Empty;
            var currentStringToRemove = string.Empty;
            var builder = new StringBuilder();
            Stack<string> result = new Stack<string>();
            result.Push(builder.ToString());
            for (int i = 0; i < N; i++)
            {
                var cmd = Console.ReadLine().Split();
                var action = cmd[0];
                if (action == "1")
                {
                    builder.Append(cmd[1]);
                    result.Push(builder.ToString());
                }
                else if (action == "2")
                {
                    var count = int.Parse(cmd[1]);
                    builder.Remove(builder.Length - count, count);
                    result.Push(builder.ToString());
                }
                else if (action == "3")
                {
                    var index = int.Parse(cmd[1]);
                    Console.WriteLine(builder[index - 1]);
                }
                else if (action == "4")
                {
                    result.Pop();
                    builder = new StringBuilder();
                    builder.Append(result.Peek());
                }

            }
        }
    }
}
