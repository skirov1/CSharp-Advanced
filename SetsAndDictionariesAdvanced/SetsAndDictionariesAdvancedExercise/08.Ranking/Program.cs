using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            var contests = new Dictionary<string, string>();
            var students = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                var data = Console.ReadLine().Split(":");
                if (data[0] == "end of contests")
                {
                    break;
                }
                var contest = data[0];
                var password = data[1];
                contests[contest] = password;
            }
            while (true)
            {
                var data = Console.ReadLine().Split("=>");
                if (data[0] == "end of submissions")
                {
                    break;
                }
                var contest = data[0];
                var password = data[1];
                var username = data[2];
                var points = int.Parse(data[3]);

                if (!students.ContainsKey(username))
                {
                    students[username] = new Dictionary<string, int>();
                }

                if (contests.ContainsKey(contest))
                {
                    if (contests[contest] == password)
                    {
                        if (!students[username].ContainsKey(contest))
                        {
                            //students[username] = new Dictionary<string, int>();
                            students[username].Add(contest, points);
                        }
                        else
                        {
                            if (points > students[username][contest])
                            {
                                students[username][contest] = points;
                            }
                        }
                    }
                }
            }
            var bestStudent = string.Empty;
            var bestStudentPoints = long.MinValue;
            foreach (var student in students)
            {
                var currentStudentPoints = 0;
                foreach (var item in student.Value)
                {
                    currentStudentPoints += item.Value;
                }
                if (currentStudentPoints > bestStudentPoints)
                {
                    bestStudentPoints = currentStudentPoints;
                    bestStudent = student.Key;
                }
            }
            Console.WriteLine($"Best candidate is {bestStudent} with total {bestStudentPoints} points.");
            Console.WriteLine("Ranking: ");
            foreach (var student in students.OrderBy(x => x.Key))
            {
                if (student.Value.Count > 0)
                {
                    Console.WriteLine($"{student.Key}");
                    foreach (var contest in student.Value.OrderByDescending(x => x.Value))
                    {
                        Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                    }
                }
            }
        }
    }
}
