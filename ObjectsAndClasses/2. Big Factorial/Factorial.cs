using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class Factorial
{
    public Factorial(int n)
    {
        N = n;  
    }

    public int N { get; set; }

    public BigInteger Calculate()
    {
        BigInteger sum = N;

        while (N > 1)
        {
            sum = sum * (N - 1);
            N--;
        }
        return sum;
    }
}