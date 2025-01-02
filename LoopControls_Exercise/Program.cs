// See https://aka.ms/new-console-template for more information
using System;
using System.Net.Http.Headers;
using System.Net.Mail;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;

namespace ControlStatements_Exercise
{
    class LoopsControls
    {

        static void Main(string[] args)
        {
            // break statement

            string[] names = { "Mounika", "Lavanya", "Daya", "Ranjith" };

            Console.WriteLine("Searching for Daya ? ");
            Console.WriteLine();

            foreach (string name in names)
            {
                if (name == "Daya")
                {
                    Console.WriteLine(" Found " + name);
                    break;
                }
            }
            Console.WriteLine();

            // Continue statement

            Console.WriteLine("Skip the name start with L : ");
            Console.WriteLine();

            foreach(string name in names)
            {
                if (name.StartsWith("L"))
                {
                    continue;
                }
                Console.WriteLine(name);
            }
            Console.WriteLine();

        // goto statement

        Retry:
            Console.WriteLine(" Enter number is greater than 10 ");
            int n;
            var number = Console.ReadLine();
            bool isnum = int.TryParse(number, out n);

            bool check = Regex.IsMatch(number, @"^[0-9]+$");
            if (check)
            {

                if (n > 10)
                {
                    Console.WriteLine($"You have entered valid number : {number}");
                }
                else if (n < 10)
                {

                    Console.WriteLine($"The number must be greater than 10. Try again");
                    goto Retry;
                }
            }
            else
            {
                Console.WriteLine($"Invalid input please enter numeric value ");
                goto Retry;
            }


        }
    }
}