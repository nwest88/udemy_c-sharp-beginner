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
            int number = 1;
            number = number + 1;
            number = number - 1;
            //prefix form for incramenting a variable
            ++number;
            //suffix form for incramenting a variable
            number++;
            //prefix form for decramenting a variable
            ++number;
            //suffix form for decramenting a variable
            number++;
            //to increase a variable by more than one
            number += 2; //number = number + 2;
            number -= 3; //number = number - 3;
            number *= 4;
            number /= 5;
            Console.WriteLine(number);
            Console.ReadKey();

        }
    }
}

