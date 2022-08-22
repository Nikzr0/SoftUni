using System;

namespace Ex05.DateModifier
{
    class Program
    {
        class DateModifier
        {   
            public double DateDifference(DateTime startDate, DateTime endDate)
            {
                if (startDate < endDate)
                {
                    return (endDate.Date - startDate.Date).Days;
                }
                else
                {
                    return (startDate.Date - endDate.Date).Days;
                }
            }
        }

        static void Main()
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            var FirstDate = DateTime.Parse(firstDate);
            var SecondDate = DateTime.Parse(secondDate);

            DateModifier dateModifier = new DateModifier();
            Console.WriteLine();
            Console.WriteLine(dateModifier.DateDifference(FirstDate, SecondDate));
        }
    }
}