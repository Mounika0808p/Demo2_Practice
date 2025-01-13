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
            }
        }
    }
}