using System;
using System.Linq;

class Program
{
    static void PassportShecker(string password)
    {
        bool OnlyLettersOrDigets = true;
        var count = password.Count(x => Char.IsDigit(x));// count how many digets are there in the string password.
        int problemCounter = 0;// I use it to print "The lpassword is valid" if it is 0.

        foreach (var item in password)// If password contains something different from letters of digets OnlyLettersOrDigets == false;
        {
            if (!Char.IsLetterOrDigit(item))
                OnlyLettersOrDigets = false;
        }

        if (password.Length < 6 || password.Length > 10)
        {
            Console.WriteLine("Password must be between 6 and 10 characters ");
            problemCounter = 1;
        }

        if (OnlyLettersOrDigets == false)
        {
            Console.WriteLine("Password must consist only of letters and digits");
            problemCounter = 1;
        }

        if (count < 2)
        {
            Console.WriteLine("Password must have at least 2 digits");
            problemCounter = 1;
        }

        if (problemCounter == 0)
        {
            Console.WriteLine("Password is valid");
        }
    }
    static void Main()
    {
        string word = Console.ReadLine();
        PassportShecker(word);
    }
}