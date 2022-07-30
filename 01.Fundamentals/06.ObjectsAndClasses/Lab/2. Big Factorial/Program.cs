using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Factorial calculator = new Factorial(n);
        Console.WriteLine(calculator.Calculate());
    }
}