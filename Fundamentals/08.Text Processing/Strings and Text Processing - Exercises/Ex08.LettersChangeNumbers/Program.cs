using System;
using System.Linq;

namespace Ex08.LettersChangeNumbers
{
    class Program
    {
        static void Main()
        {
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            char[] alphaToLower = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower().ToCharArray();

            string input = Console.ReadLine();
            string[] command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            double sum = 0;
            double number = 0;
            int positionOfsecondLetter = 0;
            int alphaPosition = 0;

            for (int i = 0; i < command.Length; i++)
            {
                string x = command[i];
                string firstLetter = x[0].ToString();
                string lastLetter = x[command[i].Length - 1].ToString();
                var a = new string(command[i].Skip(1).Take(command[i].Length - 2).ToArray());
                number = double.Parse(a.ToString());

                for (int j = 0; j < alpha.Length; j++)
                {
                    if (alpha[j].ToString() == firstLetter)
                    {
                        alphaPosition = j + 1;
                        number = number / alphaPosition;
                        j = alpha.Length - 1;
                    }
                    else if (alphaToLower[j].ToString() == firstLetter)
                    {
                        alphaPosition = j + 1;
                        number = number * alphaPosition;
                        j = alpha.Length - 1;
                    }
                }

                for (int y = 0; y < alpha.Length; y++)
                {
                    if (alpha[y].ToString() == lastLetter)
                    {
                        positionOfsecondLetter = y + 1;
                        number = number - positionOfsecondLetter;
                        y = alpha.Length - 1;
                    }
                    else if (alphaToLower[y].ToString() == lastLetter)
                    {
                        positionOfsecondLetter = y + 1;
                        number = number + positionOfsecondLetter;
                        y = alpha.Length - 1;
                    }
                }

                sum = sum + number;
                number = 0;
            }

            Console.WriteLine($"{sum:f2}") ;
        }
    }
}
