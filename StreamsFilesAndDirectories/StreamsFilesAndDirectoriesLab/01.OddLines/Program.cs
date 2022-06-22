using System;
using System.IO;

namespace OddLines
{
    public class OddLines
    {
        public static void Main()
        {
            var inputFilePath = @"D:\C#\SoftUni\ADVANCED\StreamsFilesAndDirectoriesLab\01.OddLines\input.txt";
            var outputFilePath = @"D:\C#\SoftUni\ADVANCED\StreamsFilesAndDirectoriesLab\01.OddLines\output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);
        }
        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            using StreamReader sr = new StreamReader(inputFilePath);
            using StreamWriter sw = new StreamWriter(outputFilePath);
            int row = 0;

            while (!sr.EndOfStream)
            {
                var line = sr.ReadLine();
                if (row % 2 == 1)
                {
                    sw.WriteLine(line);
                }
                row++;
            }
        }

    }
}
