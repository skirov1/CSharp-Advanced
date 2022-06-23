using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var date1 = Console.ReadLine();
            var date2 = Console.ReadLine();
            DateModifier dateModifier = new DateModifier();
            Console.WriteLine(dateModifier.CalculateDifference(date1, date2));
        }
    }
}
