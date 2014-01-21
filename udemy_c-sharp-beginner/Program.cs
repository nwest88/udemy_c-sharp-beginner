using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace udemy_c_sharp_beginner
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            num1 = 24;
            num2 = 13;
            Console.WriteLine(num1 + num2);
            Console.WriteLine(num1 - num2);
            Console.WriteLine(num1 * num2);
            Console.WriteLine(num1 / num2);
            Console.WriteLine(num1 % num2);
            //You can use modulous or % to determine if args number is even.
            //Any number mod 2 that has a result of 0 is even.
            Console.WriteLine(4 % 2);
            Console.WriteLine(4 % 3);
            Console.ReadKey();

        }
    }
}

