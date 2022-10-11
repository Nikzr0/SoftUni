using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Ex07.CustomException
{
    public class InvalidPersonNameException : Exception
    {
        public string Name { get; set; }
        public InvalidPersonNameException(string name)
        {
            Name = name;
        }

        public string  NameChecker()
        {
            bool containsInt = Name.Any(char.IsDigit);

            if (containsInt)
            {
                throw new InvalidPersonNameException("The name mustn't contain any digits!!");
            }

            return "Succes! The name is acceptable";
        }
    }
    public class Program
    {
        static void Main()
        {
            string name = Console.ReadLine();
            InvalidPersonNameException invalidPersonNameException = new InvalidPersonNameException(name);
            
            try
            {
                Console.WriteLine($"{invalidPersonNameException.NameChecker()}");
            }
            catch (InvalidPersonNameException e)
            {
                Console.WriteLine("ERROR " + e.Message);
                Console.WriteLine("The name mustn't contain any digits!!");
            }
        }
    }
}