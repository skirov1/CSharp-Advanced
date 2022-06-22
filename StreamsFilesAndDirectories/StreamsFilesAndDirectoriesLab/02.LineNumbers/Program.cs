using System;
using System.IO;

namespace LineNumbers
{
    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"D:\C#\SoftUni\ADVANCED\StreamsFilesAndDirectoriesLab\02.LineNumbers\input.txt";
            string outputFilePath = @"D:\C#\SoftUni\ADVANCED\StreamsFilesAndDirectoriesLab\02.LineNumbers\output.txt";

            RewriteFileWithLineNumbers(inputFilePath, outputFilePath);
        }

        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {
            using StreamReader sr = new StreamReader(inputFilePath);
            using StreamWriter sw = new StreamWriter(outputFilePath);

            int row = 1;

            while (!sr.EndOfStream)
            {
                var line = sr.ReadLine();
                sw.WriteLine($"{row}. {line}");
                row++;
            }
        }
    }

}
