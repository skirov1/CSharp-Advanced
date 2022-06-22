using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordCount
{

    public class WordCount
    {
        static void Main(string[] args)
        {
            var wordsFilePath = @"D:\C#\SoftUni\ADVANCED\StreamsFilesAndDirectoriesLab\03.WordCount\words.txt";
            var textFilePath = @"D:\C#\SoftUni\ADVANCED\StreamsFilesAndDirectoriesLab\03.WordCount\text.txt";
            var outputFilePath = @"D:\C#\SoftUni\ADVANCED\StreamsFilesAndDirectoriesLab\03.WordCount\output.txt";

            CalculateWordCounts(wordsFilePath, textFilePath, outputFilePath);

        }
        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            Dictionary<string, int> words = new Dictionary<string, int>();

            using StreamReader sr = new StreamReader(textFilePath);
            using StreamReader sr2 = new StreamReader(wordsFilePath);
            using StreamWriter sw = new StreamWriter(outputFilePath);

            var wordsList = sr2.ReadLine().Split();
            while (!sr.EndOfStream)
            {
                var line = sr.ReadLine().ToLower();
                for (int i = 0; i < wordsList.Length; i++)
                {
                    var word = wordsList[i].ToString().ToLower();
                    if (line.Contains(word))
                    {
                        if (!words.ContainsKey(word))
                        {
                            words[word] = 0;
                        }
                        words[word]++;
                    }
                }
            }
            words = words.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            foreach (var word in words)
            {
                sw.WriteLine($"{word.Key} - {word.Value}");
            }
        }
    }

}
