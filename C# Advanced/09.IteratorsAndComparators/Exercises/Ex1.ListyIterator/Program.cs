using System;
using System.Linq;

namespace Ex1.ListyIterator
{
    public class Program
    {
        static void Main()
        {
            string command = "";
            ListlyIterator<string> listly = null;

            while ((command = Console.ReadLine()) != "End")
            {
                var token = command.Split(" ");

                if (token[0] == "Create")
                {
                    listly = new ListlyIterator<string>(token.Skip(1).ToArray());
                }
                else if (token[0] == "Move")
                {
                    Console.WriteLine(listly.Move());
                }
                else if (token[0] == "Print")
                {
                    listly.Print();
                }
                else if (token[0] == "HasNext")
                {
                    Console.WriteLine(listly.HasNext());
                }              
            }
        }
    }
}