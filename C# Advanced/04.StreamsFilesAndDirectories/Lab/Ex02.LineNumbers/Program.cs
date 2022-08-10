using System;
using System.IO;

namespace Ex02.LineNumbers
{
    internal class Program
    {
        static void Main()
        {
            using StreamReader sr = new StreamReader("linenumbers.txt");
            using StreamWriter sw = new StreamWriter("numberedlines.txt");


            int counter = 0;
            while (!sr.EndOfStream)
            {
                counter++;
                var line = sr.ReadLine();
                sw.WriteLine($"{counter}. {line}");
            }

        }
    }
}