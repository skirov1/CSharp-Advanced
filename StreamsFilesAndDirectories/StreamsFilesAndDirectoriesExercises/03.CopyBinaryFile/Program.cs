using System;
using System.IO;

namespace CopyBinaryFile
{
    public class CopyBinaryFile
    {
        static void Main(string[] args)
        {
            var inputPath = @"D:\C#\SoftUni\ADVANCED\StreamsFilesAndDirectoriesExercises\03.CopyBinaryFile\input.bin";
            var outputPath = @"D:\C#\SoftUni\ADVANCED\StreamsFilesAndDirectoriesExercises\03.CopyBinaryFile\output.bin";
            CopyFile(inputPath, outputPath);
        }
        public static void CopyFile(string inputFilePath, string outputFilePath)
        {
            using FileStream fs = File.OpenRead(inputFilePath);
            using FileStream fs2 = File.OpenWrite(outputFilePath);
            fs.CopyTo(fs2);
        }
    }
}
