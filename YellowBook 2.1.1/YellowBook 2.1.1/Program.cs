﻿using System; // instructions that tell the compiler we are using things from System namespace
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YellowBook_2._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // console C# 
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            heightString = Console.ReadLine();//separates the object identifier from the method identifier
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " + woodLength + "feet");
            Console.WriteLine("The area of the glass is " + glassArea + "square meters");
        }
    }
}
