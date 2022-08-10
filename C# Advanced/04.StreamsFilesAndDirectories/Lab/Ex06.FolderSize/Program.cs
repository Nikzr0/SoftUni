using System;
using System.IO;

namespace Ex06.FolderSize
{
    internal class Program
    {
        static double DirectorySize(string path)
        {
            string[] files = Directory.GetFiles(path);
            double totalLength = 0;

            foreach (var item in files)
            {
                totalLength += new FileInfo(item).Length;
            }

            var subDirectories = Directory.GetDirectories(path);
            foreach (var item in subDirectories)
            {
                totalLength += DirectorySize(item);
            }

            return totalLength;
        }


        public static void Main()
        {
            string path = @"D:\Programming\C#\SoftUni\Code\C# Advanced\04.StreamsFilesAndDirectories\Lab\Ex06.FolderSize\bin\Debug\net5.0";

            Console.WriteLine(DirectorySize(path));
        }
    }
}