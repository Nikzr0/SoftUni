using System;

class Program
{

    static string MiddleCharacter(string word)
    {
        int lengthCounter = word.Length;
        int counter = 0;
        int middleLetterPossition = 0;

        if (word.Length % 2 != 0)// If it is uneven
        {
            while (lengthCounter != 1)
            {
                lengthCounter = lengthCounter - 2;
                counter++;
            }

            middleLetterPossition = counter;
            Console.WriteLine(word[middleLetterPossition]);
        }
        else// It is odd
        {
            while (lengthCounter != 2)
            {
                lengthCounter = lengthCounter - 2;
                counter++;
            }

            middleLetterPossition = counter;

            Console.Write(word[middleLetterPossition]);
            Console.Write(word[middleLetterPossition + 1]);
        }
        return "0";
    }
    static void Main()
    {
        string input = Console.ReadLine();
        MiddleCharacter(input);
    }
}