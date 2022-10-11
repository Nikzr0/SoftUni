using System;

namespace Ex01.SquareRoot
{
    public class SquereNumber
    {
        private int number;
        public int Number
        {
            get { return number; }
            set
            {
                number = value;
            }
        }
        public SquereNumber(int number)
        {
            Number = number;
        }
        public double GetSquereOfTheNumber()
        {
            return Math.Sqrt(Number);
        }

    }
    public class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            SquereNumber sqrt = new SquereNumber(n);

            try
            {
                Console.WriteLine(sqrt.GetSquereOfTheNumber());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Number");
            }
            finally
            {
                Console.WriteLine("Goodbye");
            }
        }
    }
}