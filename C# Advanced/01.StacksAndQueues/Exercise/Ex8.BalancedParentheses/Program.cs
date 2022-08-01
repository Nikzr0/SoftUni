using System;
using System.Collections.Generic;

namespace Ex8.BalancedParentheses
{
    public class Program
    {
        public static void Main() 
        {
            // IT DOESN'T WORK WITH STACK AND HAS ({}[]) PROBLEM
            // IT STARTS TO CHECK ELEMENTS FROM THE MIDLE UNTILL THE END, BUT IF THERE ARE ({}[]) MAKES A PROBLEM
            // THERE IS A WHAY WOTH IF VALIDATION BUT BECOMES TO LONG TO IMPLEMET AND IT'S POINTLES 
            // ONLY 66/100%

            string parentheses = Console.ReadLine();
            List<string> listOfParentheses = new List<string>();

            char[] one = { '(', ')' };
            char[] two = { '{', '}' };
            char[] tree = { '[', ']' };

            foreach (var item in parentheses)
            {
                listOfParentheses.Add(item.ToString());
            }

            int counter = 0;

            if (listOfParentheses.Count % 2 == 0)
            {
                for (int i = 0; i < listOfParentheses.Count / 2; i++)
                {
                    int count = listOfParentheses.Count / 2;
                    if (listOfParentheses[count - (1 + i)] == one[0].ToString() && listOfParentheses[count + i] == one[1].ToString())
                    {
                        counter++;
                    }
                    else if (listOfParentheses[count - (1 + i)] == two[0].ToString() && listOfParentheses[count + i] == two[1].ToString())
                    {
                        counter++;
                    }
                    else if (listOfParentheses[count - (1 + i)] == tree[0].ToString() && listOfParentheses[count + i] == tree[1].ToString())
                    {
                        counter++;
                    }
                    else if (listOfParentheses[count - (1 + i)] == one[0].ToString() && listOfParentheses[count + i] == one[1].ToString())
                    {

                    }
                }
            }

            if (listOfParentheses.Count % 2 != 0)
            {
                Console.WriteLine("NO");
            }
            else
            {
                if (counter == listOfParentheses.Count / 2)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}