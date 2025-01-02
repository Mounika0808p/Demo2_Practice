// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.ComponentModel.Design;

namespace Demo2_Practice
{
    class NullableTypes
    {

        static void Main(string[] args)
        {
            // nullable int
            
            int? nullableint = null;
            if (nullableint.HasValue)
            {
                Console.WriteLine($"Value : {nullableint}");

            }
            else
            {
                Console.WriteLine($"Value is null");
            }

            int? value = nullableint ?? 15;
            Console.WriteLine($"Default value :{value}");
            Console.WriteLine();

            // nullable string 

            string? nullablestring = null;
            if (!string.IsNullOrEmpty(nullablestring))
            {
                Console.WriteLine($"Value : {nullablestring}");

            }
            else
            {
                Console.WriteLine($"String Value is null");
            }

            string? value1 = nullablestring ?? "Hello value";
            Console.WriteLine($"Default value :{value1}");
            Console.WriteLine();

            // Example 

            int? student1 = null;
            int? student2 = 50;

            Console.WriteLine("Student 1 : " + (student1.HasValue ? $"Score : {student1.Value}" : "No score"));
            Console.WriteLine("Student 2 : " + (student2.HasValue ? $"Score : {student2.Value}" : "No score"));
        }

    }
}
 