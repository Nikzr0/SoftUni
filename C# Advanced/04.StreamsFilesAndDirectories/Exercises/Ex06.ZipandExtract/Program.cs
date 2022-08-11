using System.IO.Compression;

namespace Ex06.ZipandExtract
{
    internal class Program
    {
        static void Main()
        {
            string myFolderPath = @"C:\Users\User\Desktop\myFolder";
            string target = @"C:\Users\User\Desktop\myFolder.zip";

            ZipFile.CreateFromDirectory(myFolderPath, target);
        }
    }
}