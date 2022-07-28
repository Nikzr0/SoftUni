using System;

namespace ExamPreparation_Test2
{
    public class Program
    {
        public static void Main()
        {
            string word = Console.ReadLine();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Decode")
                {
                    break;
                }

                string[] instructions = input.Split("|");

                switch (instructions[0]) 
                {
                    case "Move":
                        int lettersToMove = int.Parse(instructions[1]);

                        string letters = word.Substring(0, lettersToMove); 
                        word = word.Remove(0, lettersToMove);

                        word = word.Insert(word.Length, letters);

                        break;

                    case "Insert":
                        int index = int.Parse(instructions[1]);
                        string value = instructions[2];

                        word = word.Insert(index, value);

                        break;

                    case "ChangeAll":
                        string letterToChanege = instructions[1];
                        string replaceLetter = instructions[2];

                        word = word.Replace(letterToChanege, replaceLetter);
                        break;
                }
            }
            Console.WriteLine($"The decrypted message is: {word}");
        }
    }
}