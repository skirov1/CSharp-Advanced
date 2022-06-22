using System;
using System.IO;

namespace FolderSize
{
    public class FolderSize
    {
        static void Main(string[] args)
        {
            var folderPath = Console.ReadLine();
            var outputPath = Console.ReadLine();
            GetFolderSize(folderPath, outputPath);
        }
        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            StreamWriter sw = new StreamWriter(outputFilePath);
            var dirInfo = new DirectoryInfo(folderPath);
            var infos = dirInfo.GetFiles("*", SearchOption.AllDirectories);

            double sum = 0;

            foreach (var fileInfo in infos)
            {
                sum += fileInfo.Length;
            }

            sum /= 1000;
            sw.WriteLine(sum + "KB");
        }

    }
}
