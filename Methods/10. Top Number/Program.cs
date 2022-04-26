using System;

class Program
{
    static void TopNum(int num)
    {
        int[] array = new int[num];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i + 1;
        }

        for (int i = 0; i < array.Length; i++)
        {
            int digitsValue = 0;
            int temp = 0;
            temp = array[i];
            bool isThereAnOddNum = false;

            while (temp >= 1)
            {
                digitsValue = digitsValue + temp % 10;

                if ((temp % 10) % 2 != 0)
                {
                    isThereAnOddNum = true;
                }

                temp /= 10;
            }

            if (digitsValue % 8 == 0 && isThereAnOddNum == true)
            {
                Console.WriteLine(array[i]);
            }
        }
    }

    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        TopNum(num);
    }
}