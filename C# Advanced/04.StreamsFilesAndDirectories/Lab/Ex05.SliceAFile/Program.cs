using System;
using System.Collections.Generic;
using System.IO;

namespace Ex05.SliceAFile
{
    internal class Program
    {
        static void Main()
        {
            using StreamWriter text1 = new StreamWriter("text1.txt");
            using StreamWriter text2 = new StreamWriter("text2.txt");
            using StreamWriter text3 = new StreamWriter("text3.txt");
            using StreamWriter text4 = new StreamWriter("text4.txt");
            using StreamReader input = new StreamReader("wholetext.txt");

            List<char> list = new List<char>();


            while (!input.EndOfStream)
            {
                string line = input.ReadLine();

                foreach (var item in line)
                {
                    list.Add(item);
                }
            }

            for (int i = 0; i < list.Count; i++)
            {
                if (i < list.Count / 4)
                {
                    text1.Write(list[i]);
                }
                else if (i >= list.Count / 4 && i < list.Count / 2)
                {
                    text2.Write(list[i]);
                }
                else if (i >= list.Count / 2 && i < list.Count - list.Count / 4)
                {
                    text3.Write(list[i]);
                }
                else
                {
                    text4.Write(list[i]);
                }
            }


        }
    }
}