using System;
using System.IO;

namespace DirectoryTraversal
{
    public class DirectoryTraversal
    {
        static void Main(string[] args)
        {
            var reportPath = @"‪C:\Users\Simeon\Desktop\report.txt";
            var inputFolderPath = @"D:\C#\SoftUni\ADVANCED\StreamsFilesAndDirectoriesLab\04.MergeTextFiles";
            var text = TraverseDirectory(inputFolderPath);
            WriteReportToDesktop(text, reportPath);
        }
        public static string TraverseDirectory(string inputFolderPath)
        {
            var files = Directory.GetFiles(inputFolderPath);
            var text = string.Empty;
            foreach (var file in files)
            {
                text += file;
            }
            return text;
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            using StreamWriter sw = new StreamWriter(reportFileName);
            sw.WriteLine(textContent);
        }

    }
}
