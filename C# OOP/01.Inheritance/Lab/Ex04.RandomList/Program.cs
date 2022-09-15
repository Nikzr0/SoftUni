using System;
using System.Collections.Generic;

namespace Ex04.RandomList
{
    public class RandomList<T> : List<T>
    {
        private Random random;
        public RandomList()
        {
             random = new Random();
        }

        public T GetRandomElement()
        {
            var index = random.Next(0, Count);
            return this[index];
        }

        public void RemoveRandom()
        {
            var index = random.Next(0, Count);

            this.Remove(this[index]);
        }
    }
    public class Program
    {
        static void Main()
        {
            var list = new RandomList<string>();
            list.Add("1");
            list.Add("2");
            list.Add("3");
            list.Add("4");
            list.RemoveRandom(); 
            Console.WriteLine();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}