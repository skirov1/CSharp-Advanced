using System;
using System.Collections.Generic;

namespace _04.MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            var expression = Console.ReadLine();
            Stack<int> indexes = new Stack<int>();

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    indexes.Push(i);
                }
                else if (expression[i] == ')')
                {
                    var openBracketIndex = indexes.Pop();
                    var closedBracketIndex = i;
                    Console.WriteLine(expression.Substring(openBracketIndex, closedBracketIndex - openBracketIndex + 1));
                }
            }
        }
    }
}
