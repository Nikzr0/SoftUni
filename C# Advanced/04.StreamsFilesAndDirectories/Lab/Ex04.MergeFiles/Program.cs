using System;
using System.Collections.Generic;
using System.IO;

namespace Ex04.MergeFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using StreamReader input1 = new StreamReader("input1.txt");
            using StreamReader input2 = new StreamReader("input2.txt");
            using StreamWriter output = new StreamWriter("output.txt");

            List<string> merger = new List<string>();

            while (!input1.EndOfStream)
            {
                merger.Add(input1.ReadLine());
            }

            while (!input2.EndOfStream)
            {
                merger.Add(input2.ReadLine());
            }

            foreach (var item in merger)
            {
                output.WriteLine(item);
            }
        }
    }
}