using System;

namespace ValidationAttributes
{
    public partial class StartUp
    {
        public static void Main(string[] args)
        {
            var person = new Person("Sam", 12);

            bool isValidEntity = Validator.IsValid(person);

            Console.WriteLine(isValidEntity);
        }
    }
}
