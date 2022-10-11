using System;
using System.Text;

namespace Ex05.Convert.ToDouble
{
    public class ConverToDouble
    {
        public string Number { get; set; }
        public ConverToDouble(string number)
        {
            Number = number;
        }

        public double NumberToDouble()
        {
            double result = double.Parse(Number);
            return result;
        }
    }
    public class Program
    {
        static void Main()
        {
            string number = Console.ReadLine();
            ConverToDouble converToDouble = new ConverToDouble(number);

            try
            {
                Console.WriteLine(converToDouble.NumberToDouble());
            }
            catch (FormatException)
            {
                Console.WriteLine($"The input must be a number");
            }
        }
    }
}