using System;

class Program
{
    static int AddNumbers(int a, int b)
    {
        int result = a + b;
        return result;
    }

    static int SubstractNumbers(int a, int b, int c)
    {
        return AddNumbers(a , b) - c;
    }
    static void Main()
    {
        int inputOne = int.Parse(Console.ReadLine());
        int inputTwo = int.Parse(Console.ReadLine());
        int inputThree = int.Parse(Console.ReadLine());

        Console.WriteLine(SubstractNumbers(inputOne,inputTwo,inputThree));
    }
}