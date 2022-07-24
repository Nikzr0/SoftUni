using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;
using System.Net;

namespace Regex_Exercises
{
    class Program
    {
        static void Main()
        {
            string htmlCode = "";
            double sum = 0;

            using (WebClient client = new WebClient()) // WebClient class inherits IDisposable
            {
                // Or you can get the file content without saving it
                htmlCode = client.DownloadString("https://www.olx.bg/ads/q-%D1%88%D0%B0%D1%85/?search%5Bfilter_float_price%3Afrom%5D=50&search%5Bfilter_float_price%3Ato%5D=120");
            }

            Regex regex = new Regex(@"<strong>([0-9]+.?[0-9]+) лв\.<\/strong>", RegexOptions.Singleline);


            var matches = regex.Matches(htmlCode);

            Console.WriteLine($"All chess boards in OLX between 50 and 120 лв are {matches.Count}");
            Console.WriteLine();

            foreach (Match item in matches)
            {
                Console.WriteLine($"Chess price: " + item.Groups[1].Value);
                sum += double.Parse(item.Groups[1].ToString());
            }
            Console.WriteLine();
            Console.WriteLine($"The avarage price of a chess is {sum / matches.Count:f2}");

        }
    }
}