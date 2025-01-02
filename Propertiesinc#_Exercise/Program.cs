// See https://aka.ms/new-console-template for more information
using System;

namespace Demo2_Practice
{
    class Properties
    {
        // Normal field 
        public int Rollnumber;

        // Property field

        private string name;
        public string Name
        {
            get
            { 
                return name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                    name = value;
                }
            }
        }
        static void Main(string[] args)
        {
            Properties p = new Properties();
            p.Rollnumber = 101;
            Console.WriteLine($"Roll number : {p.Rollnumber}");

            p.Name = "Mounika";
            Console.WriteLine($"Name : {p.Name}");
            Console.WriteLine();

        }
    }
}

