using System;
using System.Collections.Generic;

namespace Ex09.SimpleTextEditor
{
    public class Program
    {
        public static void Main()
        {
            int numberOfOperations = int.Parse(Console.ReadLine());

            Stack<string> elements = new Stack<string>();

            Stack<string> stackOfCommands = new Stack<string>();
            Stack<string> commandValue = new Stack<string>();

            while (numberOfOperations > 0)
            {
                string[] command = Console.ReadLine().Split(" ");

                switch (command[0])
                {
                    case "1":
                        string strToAppend = command[1];

                        string whatIsAdded = "";

                        if (strToAppend.Length == 1)
                        {
                            elements.Push(strToAppend);
                            whatIsAdded = strToAppend;
                        }
                        else
                        {
                            foreach (var item in strToAppend)
                            {
                                elements.Push(item.ToString());
                                whatIsAdded += item.ToString();
                            }
                        }


                        stackOfCommands.Push("1");
                        commandValue.Push(whatIsAdded);
                        break;

                    case "2":
                        string elementToRemove = command[1];
                        int numberOfElementsToRemove = int.Parse(command[1]);

                        string whatWasRemoved = "";
                        for (int i = 0; i < numberOfElementsToRemove; i++)
                        {
                            whatWasRemoved += elements.Pop();
                        }

                        stackOfCommands.Push("2");
                        commandValue.Push(whatWasRemoved);

                        break;

                    case "3":
                        int positionOfElementToReturn = int.Parse(command[1]);

                        int indexCounter = -1;
                        foreach (var item in elements)
                        {
                            indexCounter++;

                            if (elements.Count - indexCounter == positionOfElementToReturn)
                            {
                                Console.WriteLine(item);
                            }
                        }

                        break;

                    case "4":
                        if (stackOfCommands.Pop() == "1")
                        {
                            string whatToRemove = commandValue.Pop();

                            foreach (var item in whatToRemove)
                            {
                                elements.Pop();
                            }
                        }
                        else
                        {
                            string whatToReturn = commandValue.Pop(); // abc

                            for (int i = whatToReturn.Length - 1; i >= 0; i--)
                            {
                                elements.Push(whatToReturn[i].ToString());
                            }
                        }
                        break;
                }

                numberOfOperations--;
            }
        }
    }
}