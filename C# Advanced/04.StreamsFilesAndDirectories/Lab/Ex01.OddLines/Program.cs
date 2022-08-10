using System;
using System.IO;

namespace Ex01.OddLines
{
    public class Program
    {
        public static void Main()
        {
            using StreamReader sr = new StreamReader("OddLines.txt") ;
            using StreamWriter sw = new StreamWriter("OddLinesResult.txt") ;

            int lineNumber = 0;
            while (!sr.EndOfStream)
            {
                var line = sr.ReadLine();

                if (lineNumber % 2 != 0)
                {
                    sw.WriteLine(line);
                }

                lineNumber++;
            }

        }
    }
}