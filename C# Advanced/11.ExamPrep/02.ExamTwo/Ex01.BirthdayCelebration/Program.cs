using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex01.BirthdayCelebration
{
    public class Program
    {
        static void Main()
        {
            List<int> guestCapacity = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int[] plates = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            Stack<int> stackOfPlates = new Stack<int>();
            int wastedFood = 0;

            foreach (var item in plates)
            {
                stackOfPlates.Push(item);
            }

            while (guestCapacity.Count > 0 && stackOfPlates.Count > 0)
            {
                while (guestCapacity[0] > 0)
                {
                    int plateValue = stackOfPlates.Pop();
                    guestCapacity[0] -= plateValue;
                }

                if (guestCapacity[0] <= 0)
                {
                    wastedFood += guestCapacity[0] * -1;
                    guestCapacity.RemoveAt(0);
                }
            }

            if (guestCapacity.Count == 0)
            {
                Console.WriteLine($"Plates: {string.Join(" ", stackOfPlates)}");
                Console.WriteLine($"Wasted grams of food: {wastedFood}");
            }

            if (stackOfPlates.Count == 0)
            {
                Console.WriteLine($"Guests: {string.Join(" ", guestCapacity)}");
                Console.WriteLine($"Wasted grams of food: {wastedFood}");
            }
        }
    }
}