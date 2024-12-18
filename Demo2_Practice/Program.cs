using System;

namespace Demo2_Practice
{
    class Calculations
    {

        public int add()
        {
            int a = 10;
            int b = 20;
            int c = a + b;
            return c;

        }
        public int sub()
        {

            Console.Write("Enter first number = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter Second number = ");
            int b = int.Parse(Console.ReadLine());
            int c = a - b;
            return c;
        }
        public int mul(int e, int f)
        {
           
            return e * f;
        }
        static void Main(string[] args)
        {
            Calculations cal = new Calculations();

            Console.WriteLine(cal.add());
            Console.WriteLine(cal.sub());
            Console.WriteLine(cal.mul(1, 2));
            Console.ReadKey();


        }
    }
}
