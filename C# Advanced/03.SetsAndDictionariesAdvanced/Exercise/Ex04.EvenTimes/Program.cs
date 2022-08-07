using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex04.EvenTimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> evenTimes = new Dictionary<string, int>();
            int linesNumber = int.Parse(Console.ReadLine());

            for (int line = 0; line < linesNumber; line++)
            {
                string number = Console.ReadLine();
                if (!evenTimes.ContainsKey(number))
                {
                    evenTimes.Add(number, 1);
                }
                else
                {
                    evenTimes[number]++;
                }
            }

            foreach (var item in evenTimes.Where(x => x.Value % 2 == 0))
            {
                Console.Write(item.Key + " ");
            }
        }
    }
}
