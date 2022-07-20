using System;

class Program
{
    static void CharInRange(char firstchar, char secondchar)
    {
        int startChar = Math.Min(firstchar, secondchar);// превръща буквите в числа и ги сравнява по стойност.
        int endChar = Math.Max(firstchar, secondchar);

        for (int i = startChar + 1; i < endChar; i++)
        {
            Console.Write((char)i + " ");
        }

        Console.WriteLine();
    }


    static void Main()
    {
        char firstChat = char.Parse(Console.ReadLine());
        char seconfChar = char.Parse(Console.ReadLine());

        CharInRange(firstChat, seconfChar);
    }
}