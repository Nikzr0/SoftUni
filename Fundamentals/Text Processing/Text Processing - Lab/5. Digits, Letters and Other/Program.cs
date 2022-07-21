using System;

class Program
{
    static void Main()
    {
        string[] arr = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

        string text = Console.ReadLine();

        foreach (var item in arr)
        {
            text = text.Replace(item, new string('*', item.Length));
        }

        Console.WriteLine(text);
    }
}