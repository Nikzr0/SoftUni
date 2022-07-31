using System;

class Program
{
    static void PalindromeIntegers(string word)
    {
        string reversedWord = "";
        bool isPalindromeWord = false;
        char[] charArray = word.ToCharArray();
        Array.Reverse(charArray);
        reversedWord = new String(charArray);

        if (word == reversedWord)
        {
            isPalindromeWord = true;
        }
        else
        {
            isPalindromeWord = false;
        }
        Console.WriteLine(isPalindromeWord);
    }

    static void Main()
    {
        string input = Console.ReadLine();

        while (input != "END")
        {
            PalindromeIntegers(input);
            input = Console.ReadLine();
        }
    }
}