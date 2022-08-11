using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Ex01.DirectoryTraversal
{
    internal class Program
    {
        static void Main()
        {
            using StreamWriter fileStream = new StreamWriter(@"C:\Users\User\Desktop\report.txt");
            Dictionary<string, Dictionary<string, double>> dicOfFiles = new Dictionary<string, Dictionary<string, double>>();
            string[] allFilesNames = Directory.GetFiles(".");
            foreach (var item in allFilesNames)
            {
                FileInfo fileInfo = new FileInfo(item);
                string extention = fileInfo.Extension;
                string fileName = fileInfo.Name;
                long fileSize = fileInfo.Length / 1024;


                if (!dicOfFiles.ContainsKey(extention))
                {
                    dicOfFiles.Add(extention, new Dictionary<string, double>());
                    dicOfFiles[extention].Add(fileName, fileSize);
                }
                else
                {
                    dicOfFiles[extention].Add(fileName, fileSize);
                }

            }

            foreach (var item in dicOfFiles.OrderByDescending(x=>x.Value.Count))
            {
                fileStream.WriteLine(item.Key);
                foreach (var fileInformation in item.Value.OrderBy(x => x.Value))
                {
                    fileStream.WriteLine($"--{fileInformation.Key} - {fileInformation.Value:f3}");
                }
                fileStream.WriteLine("---------------------------------------------");
            }
        }
    }
}