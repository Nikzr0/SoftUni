using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        while (true) // makes the program run until someyhing break it!  
        {
            string comand = Console.ReadLine();

            if (comand == "end")
            {
                break;
            }

            string[] comandArray = comand.Split();

            switch (comandArray[0])
            {
                case "Add":
                    int addToNumbets = int.Parse(comandArray[1]);
                    numbers.Add(addToNumbets);
                    break;

                case "Remove":
                    int removeFromNumbets = int.Parse(comandArray[1]);
                    numbers.Remove(removeFromNumbets);
                    break;

                case "RemoveAt":
                    int removeAtFromNumbets = int.Parse(comandArray[1]);
                    numbers.RemoveAt(removeAtFromNumbets);
                    break;

                case "Insert":
                    int insertNumber = int.Parse(comandArray[1]);
                    int positionToInsert = int.Parse(comandArray[2]);
                    numbers.Insert(positionToInsert, insertNumber);// position then number
                    break;
            }
        }
        Console.WriteLine(string.Join(" ",numbers));
    }
}