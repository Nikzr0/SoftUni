using System;
class Program
{
    static void Main()
    {
        string[] paths = Console.ReadLine().Split(@"\", StringSplitOptions.RemoveEmptyEntries);

        string[] listOfTqo = paths[paths.Length - 1].Split(".");
        string path = listOfTqo[0];
        string extention = listOfTqo[1];

        Console.WriteLine($"File name: {path}");
        Console.WriteLine($"File extension: {extention}");
    }
}