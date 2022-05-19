using System;
using System.Collections.Generic;

class Massage
{
    public string Phrase { get; set; }
    public string EventName { get; set; }
    public string Author { get; set; }
    public string City { get; set; }

}
class Program
{
    static void Main()
    {
        // {phrase} {event} {author} – {city}
        List<string> items = new List<string>();

        List<string> phrases = new List<string>() { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
        List<string> events = new List<string>() { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
        List<string> authors = new List<string>() { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
        List<string> coties = new List<string>() { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
        Massage massage = new Massage();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Random randomItem = new Random();
            int r = randomItem.Next(events.Count);
            massage.Phrase = phrases[r];

            int t = randomItem.Next(phrases.Count);
            massage.EventName = events[t];

            int y = randomItem.Next(authors.Count);
            massage.Author = authors[y];

            int u = randomItem.Next(coties.Count);
            massage.City = coties[u];

            items.Add($"{massage.Phrase} {massage.EventName} {massage.Author} – {massage.City}");
        }

        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }
}