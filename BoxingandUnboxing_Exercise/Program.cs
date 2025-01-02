// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;

namespace Demo2_Practice
{
    class BoxingUnboxing
    {
        static void Main(string[] args)
        {
            // to store diff typers of data to create arraylist
            ArrayList datalist = new ArrayList();

            int intvalue = 12345;
            double doublevalue = 12345.876;
            string str = "Mounika";

            // boxing happens automatically when added to arraylist
            datalist.Add(intvalue);
            Console.WriteLine($"Boxed intvalue :{intvalue}");
            datalist.Add(doublevalue);
            Console.WriteLine($"Boxed doublevalue : {doublevalue}");
            datalist.Add(str);
            Console.WriteLine($"Boxed string : {str}");
            Console.WriteLine();

            // unboxing to their original datatype

            foreach (object obj in datalist) {

                if (obj is int)
                {
                    int unboxedint = (int)obj;
                    Console.WriteLine($"unboxed intvalue : {unboxedint}");
                }
                else if (obj is double)
                {

                    double unboxeddouble = (double)obj;
                    Console.WriteLine($"unboxed doublevalue : {unboxeddouble}");
                }
                else if (obj is string)
                {
                    string unboxedstring = (string)obj;
                    Console.WriteLine($"unboxed string :{unboxedstring}");
                }


            }


        }

    }
}


