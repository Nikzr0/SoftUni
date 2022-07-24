using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace Ex01.Furniture
{
    class Program
    {
        static void Main()
        {
            List<string> list = new List<string>();
            string output = "";
            double sum = 0;

            while (true)
            {
                string input = Console.ReadLine(); // >>Sofa<<312.23!3


                if (input == "Purchase")
                {
                    break;
                }

                Regex regex = new Regex(@"<strong>([0-9]+.?[0-9]+) лв\.<\/strong>", RegexOptions.Singleline);

                var matches = regex.Matches(input);

                output = Regex.Match(input, @">>([A-z]+)<<([0-9]+.?[0-9]+)!([0-9]+)").Groups[1].Value;
                if (output != "")
                {
                    list.Add(output);
                }

                output = Regex.Match(input, @">>([A-z]+)<<([0-9]+.?[0-9]+)!([0-9]+)").Groups[2].Value;
                double a = 0;
                if (output != "")
                {
                    a = double.Parse(output);
                    list.Remove(output);
                }
                output = Regex.Match(input, @">>([A-z]+)<<([0-9]+.?[0-9]+)!([0-9]+)").Groups[3].Value;
                double b = 0;
                if (output != "")
                {
                    b = double.Parse(output);
                }
                sum += a * b;
            }

            Console.WriteLine("Bought furniture:");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total money spend: {sum:f2}");

        }
    }
}