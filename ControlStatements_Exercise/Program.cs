// See https://aka.ms/new-console-template for more information
using System;

namespace ControlStatements_Exercise
{
    class Loops
    {

        static void Main(string[] args)
        {
            // if - else 

            int a = 10;
            int b = 20;

            if (a != b)
            {
                Console.WriteLine("Condition TRUE");
            }
            else
            {
                Console.WriteLine("Condition FALSE");
            }
            Console.WriteLine();

            // if - else - if

            int c = 10;
            int d = 20;
            int e = 20;

            if (c == d)
            {
                Console.WriteLine("Condition TRUE");
            }
            else if (d != e)
            {
                Console.WriteLine("Condition FALSE");
            }
            else
            {
                Console.WriteLine("Both conditions are Failed");
            }
            Console.WriteLine();

            // Swith Condition 

            String Name = "Mounika";

            switch (Name)
            {
                case "Radha":
                    Console.WriteLine("Hello Radha");
                    break;
                case "Rajesh":
                    Console.WriteLine("Hello Rajesh");
                    break;
                case "Mounika":
                    Console.WriteLine("Hello Mounika");
                    break;
                case "Daya":
                    Console.WriteLine("Hello Daya");
                    break;
                case "Lavanya":
                    Console.WriteLine("Hello Lavanya");
                    break;
            }
            Console.WriteLine();

            // While loop 

            int number = 1;

            while (number < 10)
            {
                Console.WriteLine(number);
                number++;

            }
            Console.WriteLine();

            // do - while loop 

            int number2 = 0;

            do
            {

                Console.WriteLine("print the current value of the number = " + number2);
                number2++;

            }
            while (number2 <= 5);

            Console.WriteLine();



            // for loop


            int i = 0;

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("count = " + i);
            }

            Console.WriteLine();

            // for each loop 

            int[] nums = { 1, 2, 3, 4, 5, 6, 7, };

            foreach (int x in nums)
            {
                Console.WriteLine(x);
            }

            string[] s = { "mounika", "radha", "daya" };

            List<string> list = new List<string>();

            foreach (string name in s)
            {

                list.Add(name);
            }
            Console.WriteLine(" names in the list : ");
            foreach (string name in list)

            {
                Console.WriteLine(name);
            }

            foreach (string names in s)

                { 
                Console.WriteLine(names); 
            }
            

        }


    }
}
