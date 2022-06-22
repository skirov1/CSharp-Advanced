using System;
using System.IO;
using System.Text.RegularExpressions;

namespace LineNumbers
{
    public class LineNumbers
    {
        static void Main(string[] args)
        {
            var inputPath = @"D:\C#\SoftUni\ADVANCED\StreamsFilesAndDirectoriesExercises\02.LineNumbers\text.txt";
            var outputPath = @"D:\C#\SoftUni\ADVANCED\StreamsFilesAndDirectoriesExercises\02.LineNumbers\output.txt";
            ProcessLines(inputPath, outputPath);
        }
        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            using StreamReader sr = new StreamReader(inputFilePath);
            using StreamWriter sw = new StreamWriter(outputFilePath);

            var row = 1;

            while (!sr.EndOfStream)
            {
                var line = sr.ReadLine();
                MatchCollection lettersMatches = Regex.Matches(line, @"\w");
                MatchCollection spaceMatches = Regex.Matches(line, @" ");
                sw.WriteLine($"Line {row}: {line} ({lettersMatches.Count})({line.Length - lettersMatches.Count - spaceMatches.Count})");
                row++;
            }
        }

    }
}
