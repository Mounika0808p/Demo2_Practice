// See https://aka.ms/new-console-template for more information
using System;

namespace Arrays_Execise
{
    class Employee
    {
        // Single-dimensional array
        public string[] Names { get; set; } = new string[3];

        // Multi-dimensional array
        public decimal[,] Salaries { get; set; } = new decimal[3, 5];


    }




    class Program
    {
        static void Main(string[] args)
        {

            Employee employee = new Employee();

            // Employee names from console
            Console.WriteLine("Enter the names of 3 employees = ");

            for (int i = 0; i < employee.Names.Length; i++)
            {
                Console.Write($"Employee {i + 1}: ");
                employee.Names[i] = Console.ReadLine();
            }

            // Employee salaries from console
            Console.WriteLine("\nEnter monthly salaries for each employee:");
            for (int i = 0; i < employee.Names.Length; i++)
            {
                Console.WriteLine($"Enter salaries for {employee.Names[i]}:");

                for (int j = 0; j < 5; j++)

                {
                    Console.Write($"Month {j + 1}: ");

                    employee.Salaries[i, j] = Convert.ToDecimal(Console.ReadLine());
                }
            }

            // Displaying Employee Details
            Console.WriteLine("\n Employee Salary Details =");
            for (int i = 0; i < employee.Names.Length; i++)
            {
                Console.WriteLine($"\nEmployee: {employee.Names[i]}");
                decimal totalSalary = 0;

                // Displaying monthly salaries and calculating total
                Console.WriteLine("Monthly Salaries:");
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine($"Month {j + 1}: {employee.Salaries[i, j]}");
                    totalSalary += employee.Salaries[i, j];
                }

                Console.WriteLine($"Total Salary for 5 months : {totalSalary}");
                Console.WriteLine($"Average Monthly Salary: {totalSalary / 5}");
                Console.WriteLine();
            }




            // jagged array 

            Console.WriteLine("Jagged array example");

            int[][] studentscore = new int[3][];

            studentscore[0] = new int[] { 85, 90, 89 };         // Class A
            studentscore[1] = new int[] { 89, 99 };            // Class B
            studentscore[2] = new int[] { 96, 77, 89, 96 };      // Class C

            // Display the jagged array
            Console.WriteLine("Displaying student scores = ");
            for (int i = 0; i < studentscore.Length; i++)
            {
                Console.Write($"Student {i + 1}: ");
                for (int j = 0; j < studentscore[i].Length; j++)
                {
                    Console.Write(studentscore[i][j] + " ");
                }
                Console.WriteLine();
            }


            Console.WriteLine("\nAccessing a specific student score ");
            Console.WriteLine($"Score of Student[2][3]: {studentscore[2][3]}");
        }




    }
}
