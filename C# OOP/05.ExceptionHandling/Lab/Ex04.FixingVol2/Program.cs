using System;
using System.Runtime.Intrinsics.Arm;

namespace Ex04.FixingVol2
{
    public class Program
    {
        static void Main()
        {
            int firstNumber, secondNumber;
            byte result = 0;

            firstNumber = 30;
            secondNumber = 60;

            try
            {
                result = Convert.ToByte(firstNumber * secondNumber);
            }
            catch (OverflowException e)
            {
                Console.WriteLine($"The error is: {e.Message}");
                Console.WriteLine($"{firstNumber} x {secondNumber} = {firstNumber * secondNumber}");// Maybe not the right way!
            }

        }
    }
}