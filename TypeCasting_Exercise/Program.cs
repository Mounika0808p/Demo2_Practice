// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;

namespace TypeCasting_Exercise
{
    class Typecasting
    {

        // implicit casting : From smaller to larger numeric values.
        // byte -> short -> int -> long -> float -> double -> 
        static void Main(string[] args)
        {
            int integer = 10;
            double doublevalue = integer;

            Console.WriteLine(integer);
            Console.WriteLine(doublevalue);
            Console.WriteLine();

            int i = 250000;
            long l = i;
            float f = 15.9f;
            double d = f;
            Console.WriteLine(i);
            Console.WriteLine(l);
            Console.WriteLine(f);
            Console.WriteLine(d);
            Console.WriteLine();

            // explict Typecasting : From larger to smaller conversion 

            double dvalue = 123.45;
            int ivalue = (int)dvalue;
            Console.WriteLine(dvalue);
            Console.WriteLine(ivalue);
            Console.WriteLine();

            char c = 'M';
            int value = (int)c;
            Console.WriteLine(value);

            int value1 = 66;
            char character = (char)value1; 
            Console.WriteLine(character);
            Console.WriteLine();



        }


    }
}