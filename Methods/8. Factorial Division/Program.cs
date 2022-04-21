using System;

class Program
{
    static void Factorial(int firstInput, int seconInput)
    {
        double sum = 0;
        double sumInputOne = firstInput;
        double sumInputTwo = seconInput;

        for (int i = firstInput - 1; i >= 2; i--)
        {
            sumInputOne = sumInputOne * i;
        }

        for (int i = seconInput - 1; i >= 2; i--)
        {
            sumInputTwo = sumInputTwo * i;
        }

        sum = sumInputOne / sumInputTwo;
        Console.WriteLine($"{sum:f2}");

    }
    static void Main()
    {
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());
        Factorial(firstNum, secondNum);
    }
}