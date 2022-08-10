using System;
using System.Collections.Generic;
using System.IO;

namespace Ex04.CopyBinaryFile
{
    internal class Program
    {
        static void Main()
        {
            //File.Copy("myStuff.jpg", "../../../myStuff.jpg");

            FileStream fileReader = new FileStream("myStuff.jpg", FileMode.Open);
            FileStream fileWriter = new FileStream("../../../myStuff.jpg", FileMode.Create);
            byte[] buffer = new byte[256];

            while (true)
            {
                int currBuffer = fileReader.Read(buffer, 0, buffer.Length);

                if (currBuffer == 0)
                {
                    break;
                }
                fileWriter.Write(buffer, 0, currBuffer);
            }
        }
    }
}