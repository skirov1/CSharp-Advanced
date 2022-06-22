using System;
using System.IO;

namespace EvenLines
{
    public class EvenLines
    {
        static void Main()
        {
            var path = @"D:\C#\SoftUni\ADVANCED\StreamsFilesAndDirectoriesExercises\01.EvenLines\text.txt";
            Console.WriteLine(ProcessLines(path));
        }
        public static string ProcessLines(string inputFilePath)
        {
            using StreamReader sr = new StreamReader(inputFilePath);

            var row = 0;

            while (!sr.EndOfStream)
            {
                if (row % 2 == 0)
                {
                    var line = sr.ReadLine();
                    line = line.Replace('-', '@').Replace(',', '@').Replace('.', '@').Replace('!', '@').Replace('?', '@');                 
                    var reversedLine = line.Split();
                    Array.Reverse(reversedLine);
                    return string.Join(" ", reversedLine);
                }
                row++;
            }
            return "";
        }
    }
}
