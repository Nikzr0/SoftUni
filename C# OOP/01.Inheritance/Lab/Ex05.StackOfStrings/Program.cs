using System;
using System.Collections.Generic;

namespace Ex05.StackOfStrings
{

    public class StackOfStrings : Stack<string>
    {
        public bool isEmpty()
        {
            if (this.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AddRange(IEnumerable<string> items)
        {
            foreach (var item in items)
            {
                Push(item);
            }
        }
    }
    public class Program
    {
        static void Main()
        {
            List<string> names = new List<string>();
            names.Add("Ana");
            names.Add("Ela");


            var myStack = new StackOfStrings();
            Console.WriteLine(myStack.isEmpty());
            myStack.AddRange(names);
            Console.WriteLine(myStack.isEmpty());
        }
    }
}