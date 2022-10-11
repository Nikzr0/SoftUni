using System;
using System.Linq;

namespace Ex02.EnterNumbers
{
    public class NumbersCheck
    {
        public int[] CheckNumbers(int[] numbers)
        {
            if (numbers.Length == 1)
            {
                throw new Exception("You must enter at least 2 numbers!");
            }
            else
            {
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] < numbers[i + 1] && numbers[i] < 100 && numbers[i + 1] < 100)
                    {
                    }
                    else
                    {
                        throw new Exception("InvalidNumbers");
                    }
                }
            }

            return numbers;
        }
    }
    public class Program
    {
        static void Main()
        {
            NumbersCheck nums = new NumbersCheck();

            bool isFalse = true;

            while (isFalse)
            {
                try
                {
                    nums.CheckNumbers(Console.ReadLine().Split(" ").Select(int.Parse).ToArray());
                    isFalse = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    isFalse = true;
                }
            }
            Console.WriteLine("End");
        }
    }
}