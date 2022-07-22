using System;
using System.Linq;
class Program
{
    static void Main() //Ко ??
    {
        int sequenceLength = int.Parse(Console.ReadLine()); // n

        string input = Console.ReadLine();
         int [] DNA = new int[sequenceLength];

        int dnaSUM = 0;
        int dnaCount = -1;
        int dnaStartIndex = -1;
        int dnaSamples = 0;

        int samples = 0;
        while (input != "Clone them")
        {
            samples++;
            int[] currDNA = input.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int currCount = 0;
            int startIndex = 0;
            int currentEndIndex = 0;
            bool isCurrDNABetter = false;
            int currDnaSum = 0;
            int count = 0;

            for (int i = 0; i < currDNA.Length; i++)
            {
                if (currDNA[i] != 1)
                {
                    currCount = 0;
                    continue;
                }

                currCount++;

                if (count > currCount)
                {
                    currCount = count;
                    currentEndIndex = i;
                }
            }

            startIndex = currentEndIndex - currCount + 1;
            currDnaSum = currDNA.Sum(); 
        }
    }
}