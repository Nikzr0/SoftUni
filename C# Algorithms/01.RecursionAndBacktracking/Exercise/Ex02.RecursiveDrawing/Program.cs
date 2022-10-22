using System;
using System.Linq;
using System.Text;

namespace Ex02.RecursiveDrawing
{
    public class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Draw(n);
        }    
        public static void Draw(int size)
        {
            if (size == 0)
            {
                return;
            }

            Console.WriteLine(new string('*', size)); // Pre Recursion Action
            Draw(size - 1); // Recursion
            Console.WriteLine(new string('#',size));// Post Recursion Action
        }
    }
} 