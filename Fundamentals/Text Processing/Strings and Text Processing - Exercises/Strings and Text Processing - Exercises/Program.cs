using System;
class Program
{
    static void Main()
    {
        string[] twoStrings = Console.ReadLine().Split(" ");

        string str1 = twoStrings[0];
        string str2 = twoStrings[1];

        int sum = 0;

        if (str1.Length == str2.Length) // If they are equal
        {
            for (int i = 0; i < str1.Length; i++)
            {
                sum += str1[i] * str2[i];
            }
        }
        else // If they are not equal
        {
            int temp = 0;

            if (str1.Length > str2.Length)
            {
                for (int i = 0; i < str2.Length; i++)
                {
                    sum += str1[i] * str2[i];
                    temp++;
                }

                for (int i = temp; i < str1.Length; i++)
                {
                    sum += str1[i];
                }
            }
            else
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    sum += str1[i] * str2[i];
                    temp++;
                }

                for (int i = temp; i < str2.Length; i++)
                {
                    sum += str2[i];
                }
            }
        }

        Console.WriteLine(sum);
    }
}