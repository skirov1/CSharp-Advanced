﻿using System;

namespace _02.GenericBoxOfInteger
{
    public class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var box = new Box<int>();
                box.Value = int.Parse(Console.ReadLine());
                Console.WriteLine(box.ToString());
            }
        }
    }
}