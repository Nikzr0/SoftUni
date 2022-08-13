using System;
using System.Linq;

namespace Ex05.AppliedArithmetics
{
    internal class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                switch (command)
                {
                    case "add":
                        Func<int[], int[]> add = x =>
                        {
                            for (int i = 0; i < numbers.Length; i++)
                            {
                                numbers[i] += 1;
                            }
                            return numbers;
                        };

                        add(numbers);
                        break;

                    case "multiply":
                        Func<int[], int[]> multyply = x =>
                        {
                            for (int i = 0; i < x.Length; i++)
                            {
                                numbers[i] *= 2;
                            }
                            return numbers;
                        };

                        multyply(numbers);
                        break;

                    case "subtract":
                        Func<int[], int[]> substract = x =>
                        {
                            for (int i = 0; i < x.Length; i++)
                            {
                                numbers[i] -= 1;
                            }
                            return numbers;
                        };

                        substract(numbers);
                        break;

                    case "print":
                        Action<int[]> print = x => Console.WriteLine(String.Join(" ", numbers));
                        print(numbers);
                        break;
                }
            }
        }
    }
}