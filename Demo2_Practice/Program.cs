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

        // call by value 

        static void Callbyvalue(int x)
        {
            x += 10;
            Console.WriteLine("with in function callbyvalue : "+x);
        }
        // call by reference using ref
        static void Callbyref(ref int y)
        {
            y += 10;
            Console.WriteLine("with in function callbyvalue : " + y);
        }
        // call by reference using out 
        static void Callbyrefout(out int z)
        {
            z = 10;
            Console.WriteLine("with in function callbyvalue : " + z);
        }






        static void Main(string[] args)
        {
            Calculations cal = new Calculations();

            Console.WriteLine(cal.add());
            Console.WriteLine(cal.sub());
            Console.WriteLine(cal.mul(1, 2));
            Console.WriteLine();


            int p = 5;
            Console.WriteLine("before callbyvalue : "+p);
            Callbyvalue(p);
            Console.WriteLine("after callbyvalue :"+p);

            int q = 5;
            Console.WriteLine("before callbyref : " + q);
            Callbyref(ref q);
            Console.WriteLine("after callbyref :" + q);

            int r;
            Callbyrefout(out r);
            Console.WriteLine("after callbyrefout :" + r);




        }
    }
}
