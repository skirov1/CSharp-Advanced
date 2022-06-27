using System;
using System.Collections.Generic;

namespace _02.Collection
{
    public class Program
    {
        static void Main(string[] args)
        {
            var listyIterator = new ListyIterator<string>(new List<string>());
            while (true)
            {
                var cmd = Console.ReadLine().Split();
                var action = cmd[0];
                if (action == "END")
                {
                    break;
                }
                if (action == "Create")
                {
                    var list = new List<string>();
                    for (int i = 1; i < cmd.Length; i++)
                    {
                        list.Add(cmd[i]);
                    }
                    listyIterator.List = list;
                }
                else if (action == "Move")
                {
                    Console.WriteLine(listyIterator.Move());
                }
                else if (action == "HasNext")
                {
                    Console.WriteLine(listyIterator.HasNext());
                }
                else if (action == "Print")
                {
                    listyIterator.Print();
                }
                else if (action == "PrintAll")
                {
                    Console.WriteLine(listyIterator.PrintAll());
                }
            }
        }
    }
}

