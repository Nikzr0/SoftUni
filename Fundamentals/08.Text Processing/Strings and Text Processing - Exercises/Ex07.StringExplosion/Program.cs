using System;

namespace Ex07.StringExplosion
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine(); // abv>1>1>2>2asdasd
            string finalLetters = input;
            string answer = "";

            char[] chars = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            int num = 0;
            int reservedStrength = 0;

            int counter = 0;

            foreach (var item in input) // abv>1>1>2>2asdasd
            {
                for (int i = 0; i < chars.Length; i++)
                {
                    if (item == chars[i])
                    {
                        num = int.Parse(item.ToString()) + reservedStrength; // 1;
                        int xx = num;

                        if (num == 0)
                        {
                            num++;
                            xx++;
                        }

                        for (int x = 0; x < xx; x++)
                        {
                            if (counter + x <= finalLetters.Length - 1)
                            {
                                if (finalLetters[counter + x].ToString() != ">")
                                {
                                    finalLetters = finalLetters.Remove(counter + x, 1).Insert(counter + x," ");
                                }
                                else
                                {
                                    xx = x;
                                    num++;
                                }
                            }

                            num--;
                        }

                        if (num > 0)
                        {
                            reservedStrength = num;
                            num = 0;
                        }
                    }
                }
                counter++;
            }

            foreach (var item in finalLetters)
            {
                if (item.ToString() != " ")
                {
                    answer += item;
                }
            }

            Console.WriteLine(answer);
        }
    }
}
