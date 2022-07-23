using System;

namespace Ex06.ReplaceRepeatingChars
{
    class Program
    {
        static void Main()
        {
            string letters = Console.ReadLine();

            string finnalLetters= "";
            finnalLetters += letters[0];

            for (int i = 1; i < letters.Length; i++)
            {
                if (letters[i] != letters[i -1])
                {
                    finnalLetters += letters[i];
                }
            }

            Console.WriteLine(finnalLetters);
        }
    }
}
