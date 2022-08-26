using System;

namespace Ex03.GenericScale
{
    public class Program
    {
        static void Main()
        {
            int left = int.Parse(Console.ReadLine());
            int right = int.Parse(Console.ReadLine());
            EqualityScale<int> scale = new EqualityScale<int>(left, right);
            Console.WriteLine(scale.AreEqual());
        }
    }
}