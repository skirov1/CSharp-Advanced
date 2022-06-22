using System;
using System.IO;

namespace MergeFiles
{
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"D:\C#\SoftUni\ADVANCED\StreamsFilesAndDirectoriesLab\04.MergeTextFiles\input1.txt";
            var secondInputFilePath = @"D:\C#\SoftUni\ADVANCED\StreamsFilesAndDirectoriesLab\04.MergeTextFiles\input2.txt";
            var outputFilePath = @"D:\C#\SoftUni\ADVANCED\StreamsFilesAndDirectoriesLab\04.MergeTextFiles\output.txt";
            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }
        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            using StreamReader sr1 = new StreamReader(firstInputFilePath);
            using StreamReader sr2 = new StreamReader(secondInputFilePath);
            using StreamWriter sw = new StreamWriter(outputFilePath);

            for (int i = 0; i < Math.Min(sr1.BaseStream.Length, sr2.BaseStream.Length) / 2; i++)
            {
                sw.WriteLine(sr1.ReadLine());
                sw.WriteLine(sr2.ReadLine());
            }
            while (!sr1.EndOfStream)
            {
                sw.WriteLine(sr1.ReadLine());
            }
            while (!sr2.EndOfStream)
            {
                sw.WriteLine(sr2.ReadLine());
            }
        }
    }
}

