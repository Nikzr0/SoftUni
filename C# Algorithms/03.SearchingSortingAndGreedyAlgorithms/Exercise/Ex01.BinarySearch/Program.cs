using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex01.BinarySearch
{
    public class Program
    {
        // Not 100 %
        // Maybe a problem related with the length of the input
        private static int x = 0;
        private static int middleElement;
        private static int startLength;
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(" ")
                .Select(int.Parse).ToList();
            startLength = numbers.Count;
            int targerNumber = int.Parse(Console.ReadLine());

            BinarySearcher(numbers, targerNumber, numbers.Count / 2 );
        }

        private static void BinarySearcher(List<int> numbers, int targerNumber, int index)
        {
            if (numbers.Count / 2 - 1 >= 0)
            {
                 middleElement = numbers[numbers.Count / 2 - 1];                
            }
            else
            {
                Console.WriteLine(index);
                return;
            }

            if (middleElement == targerNumber)
            {
                Console.WriteLine(index);
                return;
            }

            if (middleElement > targerNumber)
            {
                int counter = numbers.Count / 2 + 1;
                for (int i = 0; i < counter; i++)
                {
                    if (x == 0)
                    {
                        if (startLength % 2 == 0)
                        {
                            index = numbers.Count - 1;
                        }
                        else
                        {
                            index = numbers.Count - 2;
                        }
                    }
                    numbers.RemoveAt(numbers.Count - 1);

                  
                    index--;
                    x++;
                }

                if (counter == 1)
                {
                    index--;
                }
                
            }
            else if (middleElement < targerNumber)
            {
                int counter = numbers.Count / 2;
                for (int i = 0; i < counter; i++)
                {
                    if (x > 0)
                    {
                        index++;
                    }
                   
                    numbers.RemoveAt(0);
                }

                x++;
            }

            BinarySearcher(numbers, targerNumber, index);
        }
    }
}