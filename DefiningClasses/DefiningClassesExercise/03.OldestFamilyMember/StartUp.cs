using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var family = new Family();

            for (int i = 0; i < N; i++)
            {
                var data = Console.ReadLine().Split();
                var person = new Person(data[0], int.Parse(data[1]));
                family.AddMember(person);
            }
            Console.WriteLine(family.GetOldestMember().Name + " " + family.GetOldestMember().Age);
        }
    }
}
